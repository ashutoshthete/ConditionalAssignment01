using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("the number is divisible");
            }
            else
            {
                Console.WriteLine("the number is not divisible");
            }
        }
    }
}
