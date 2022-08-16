using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the number  to check if it is positive or negative");
            int num = int.Parse(Console.ReadLine());


            if (num >0)
            {
                Console.WriteLine("the number is positive");
            }else if (num == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine("the number is negative");
            }

        }
    }
}
