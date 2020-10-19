using Entry.Practice.QuestionApi.Domain.Res;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entry.Practice.QuestionApi.Controllers
{
    /// <summary>
    /// question
    /// </summary>
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {

        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public QuestionRes[] GetItem(int id = 0)
        {

            return new[]
            {
                QuestionRes.GetDefault("111,"),
                QuestionRes.GetByAnswer("222"),
                QuestionRes.GetDefault(",3333")
            };

        }

    }
}
