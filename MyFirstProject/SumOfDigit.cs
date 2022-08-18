using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class SumOfDigit
    {




        public int DSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            
            
            return sum;
        }



        static void Main(string[] args)
        {
            SumOfDigit s = new SumOfDigit();
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            int result = s.DSum(num);
            Console.WriteLine("sum of digits="+result);

        }
    }
}
