using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Snumber
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the number:");
                int num = int.Parse(Console.ReadLine());
           
                int sum = 0;
                int productsum = 1;
                int remainder;

                while (num > 0)
                {
                    remainder = num % 10;
                    sum = sum + remainder;
                    productsum = productsum * remainder;
                    num = num / 10;


                }
                if (sum == productsum)
                {
                    Console.WriteLine("It is Spy Number.");
                }
                else
                {
                    Console.WriteLine("It's not a Spy number.");
                }

            }
        }
    }
}
