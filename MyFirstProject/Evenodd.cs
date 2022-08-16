using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Evenodd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
