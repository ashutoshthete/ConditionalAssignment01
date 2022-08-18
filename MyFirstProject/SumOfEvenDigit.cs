using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class SumOfEvenDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;
            int remainder;

            while (num != 0)
            {
                remainder = num % 10;
                if (remainder % 2 == 0)
                {
                    sum = sum + remainder;
                }else if (remainder % 2 != 0)
                {
                    sum2 = sum2 + remainder;
                }
                num = num / 10;
            }
            Console.WriteLine("sum of even digits=" + sum);
            Console.WriteLine("the sum of odd num=" + sum2);
        }
    }
}
