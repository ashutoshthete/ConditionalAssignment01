using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            if(num>=0 && num <= 9)
            {
                Console.WriteLine("The number is single digit number ");
            }
            else if(num>=10 && num <= 99)
            {
                
                Console.WriteLine("The number is double digit number ");
                
            }
            else { Console.WriteLine("Invalid input"); }

        }

    }
}
