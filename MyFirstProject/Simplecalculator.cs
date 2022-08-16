using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Simplecalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the type of operation you want to perform : +,-,/,* ");
            char op = char.Parse(Console.ReadLine());
            int ans = 0;
            if (op == '+')
            {
                ans = a + b;
            }
            else if (op == '-')
            {
                ans = a - b;
            }
            else if (op == '/')
            {
                ans = a / b;
            }
            else if (op == '*')
            {
                ans = a * b;
            }
            Console.WriteLine("Your Answer is :- "+ans);
        }
    }
}
