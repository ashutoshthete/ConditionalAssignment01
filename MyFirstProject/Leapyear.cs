using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Leapyear
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());

            if(((year % 4==0) && (year% 100!=0))||(year % 400 == 0))
            {
                Console.WriteLine("It is a leap year.", year);
            }
            else {
                Console.WriteLine("year is not a leap year");
            }
            


        }
    }
}
