using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class AverageofDigitMethod
    {
        

        public  int Average(int num)
        {
            
            int sum = 0;
            int avg = 0;
            int count = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
                count++;
                avg = sum /count;

            }
            return avg;
        }

        static void Main(string[] args)
        {
            AverageofDigitMethod s = new AverageofDigitMethod();
            Console.WriteLine("Enter the nuber:");
            int num = int.Parse(Console.ReadLine());
            int result = s.Average(num);
            Console.WriteLine(result);
            

        }
    }
}
