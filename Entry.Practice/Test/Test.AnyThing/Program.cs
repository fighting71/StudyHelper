using System;

namespace Test.AnyThing
{
    class Program
    {
        static void Main(string[] args)
        {

            {// 内容解析

                string data = "<li><u>。。帮</u><u>在</u>的关的<u>问题</u></li>";

                for (int i = 0; i < data.Length; i++)
                {
                    var c = data[i];
                    if(c == '<')
                    {
                        i++;
                        string flag = GetFlag(data, ref i);

                        if(flag == "li")
                        {

                        }

                    }
                }

            }

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
