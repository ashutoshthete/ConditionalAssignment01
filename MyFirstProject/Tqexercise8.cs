using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number;");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number;");
            int num2 = int.Parse(Console.ReadLine());

            string ans = num1 > num2 ? "the first number is positive  " : "The second number is positive";
            Console.WriteLine(ans);

        }
    }
}
