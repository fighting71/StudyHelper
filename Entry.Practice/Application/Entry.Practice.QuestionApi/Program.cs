using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Entry.Practice.QuestionApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog((hostingContext, loggerConfiguration) =>
                {
                    loggerConfiguration
                     .MinimumLevel.Information()
                    .Enrich.FromLogContext()
                   .ReadFrom.Configuration(hostingContext.Configuration)
                   .Enrich.FromLogContext()
                   .WriteTo.File($"{AppContext.BaseDirectory}logs\\log.txt", rollingInterval: RollingInterval.Day, shared: true)
                   .WriteTo.Console();
                });
    }
}
