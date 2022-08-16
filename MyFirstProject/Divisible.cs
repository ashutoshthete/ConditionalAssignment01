using System;
using System.Collections.Generic;
using System.Text;


namespace MyFirstProject
{
    class Divisible
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if((num %5 == 0)&&(num % 11 == 0))
            {
                Console.WriteLine("The number is divisible by 5 & 11 .");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5");
            }
        }
    }
}
