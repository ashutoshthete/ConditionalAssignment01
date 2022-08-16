using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }else if (number == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }
    }
}
