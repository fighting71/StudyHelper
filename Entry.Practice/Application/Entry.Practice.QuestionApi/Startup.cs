using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Entry.Practice.QuestionApi
{
    public class Startup
    {
        private const string CoreCorPolicy = nameof(CoreCorPolicy);
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                // 使用全路径，避免相同类名异常
                s.CustomSchemaIds(x => x.FullName);
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Api文档",
                    Version = "v1"
                });
                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                s.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Api.xml"));
            });

            services.AddCors(options => options.AddPolicy(CoreCorPolicy,
            builder =>
            {
                builder.AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowAnyOrigin()
                        ;
            }));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(CoreCorPolicy);

            //启用swagger
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("v1/swagger.json", "question api v1");
            });

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
