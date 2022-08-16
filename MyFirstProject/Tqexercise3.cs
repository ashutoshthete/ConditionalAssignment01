using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the passing year");
            int yr = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the mrks");
            int perc = int.Parse(Console.ReadLine());
            if (yr == 2022)
            {
                if (perc > 60)
                {
                    Console.WriteLine("student is selected");
                }
                else
                {
                    Console.WriteLine("year is correct but percent is less than 60");
                }
            }

            else
            {
                Console.WriteLine("student is not selected");
            }
        }
    }
}
