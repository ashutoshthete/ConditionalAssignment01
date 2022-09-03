using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string resultstr = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if (!resultstr.Contains(str[i]))
                {
                    resultstr = resultstr + str[i];
                }
            }
            Console.WriteLine(resultstr);
        }
    }
}
