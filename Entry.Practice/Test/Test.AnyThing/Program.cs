using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Test.AnyThing
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    string txt = File.ReadAllText(@"C:/Users/Administrator/Desktop/newTest.html");

            //    string newTxt = Regex.Replace(txt, "style=\"color:#ff0000;[^\"]*\"</style>", match =>
            //    {
            //        return "style=\"color:#ff0000; \" class='answer'";
            //    });

            //}

            //{
            //    string txt = File.ReadAllText(@"C:/Users/Administrator/Desktop/newTest-format.html");

            //    string newTxt = Regex.Replace(txt, "style=\"color:#ff0000;[^\"]*\"", match =>
            //    {
            //        return "style=\"color:#ff0000; \"  class='answer'";
            //    });

            //    File.WriteAllText(@"C:/Users/Administrator/Desktop/newTest-format2.html", newTxt);
            //}

            //{
            string txt = File.ReadAllText(@"C:/Users/Administrator/Desktop/data.txt");

            string newTxt = Regex.Replace(txt, @"\d+\.", match =>
            {
                if(match.Value == "1945")
                {

                }
                return string.Empty;
            });

            File.WriteAllText(@"C:/Users/Administrator/Desktop/data-format.txt", newTxt);
            //}

            //{
            //    string txt = File.ReadAllText(@"C:/Users/Administrator/Desktop/newTest.html");

            //    string newTxt = Regex.Replace(txt, @"\d+\.", match =>
            //    {
            //        return "<br><br><br>" + match.Value;
            //    });

            //    File.WriteAllText(@"C:/Users/Administrator/Desktop/newTest-format.html", newTxt);
            //}

            //{// 内容解析

            //    string data = "<li><u>。。帮</u><u>在</u>的关的<u>问题</u></li>";

            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        var c = data[i];
            //        if(c == '<')
            //        {
            //            i++;
            //            string flag = GetFlag(data, ref i);

            //            if(flag == "li")
            //            {

            //            }

            //        }
            //    }

            //}

            Console.WriteLine("Hello World!");

            Console.ReadKey(true);

        }

        private static string GetFlag(string str, ref int index)
        {
            string res = "";
            char c;
            while ((c = str[index]) != '>')
            {
                res += c;
            }
            return res;
        }

    }
}
