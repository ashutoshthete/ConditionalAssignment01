using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check if it is Spy Number or Not:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, product = 1, r;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
               
            }
            if (sum == product)
            {
                Console.WriteLine("The number is spy number");
            }
            else
            {
                Console.WriteLine("The number is not spy number");
            }
        }
    }
}
