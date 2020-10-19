using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entry.Practice.QuestionApi.Domain.Res
{
    public class QuestionRes
    {

        public static QuestionRes GetDefault(string txt) => new QuestionRes { Txt = txt };
        public static QuestionRes GetByAnswer(string txt) => new QuestionRes { Answer = txt, NeedWrite = true };

        /// <summary>
        /// 是否需要填写
        /// </summary>
        public bool NeedWrite { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Txt { get; set; }

        /// <summary>
        /// 答案
        /// </summary>
        public string Answer { get; set; }

    }
}
