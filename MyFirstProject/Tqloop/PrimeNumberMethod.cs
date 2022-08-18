using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.Tqloop
{
    class PrimeNumberMethod
    {

        public bool IsPrime(int num)
        {
            int c = 0;
            int i = 2;
            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    c = 1;
                    break;
                }
                i++;
            }
            if (c == 0)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
            return true;
        }

        static void Main(string[] args)
        {
            PrimeNumberMethod s = new PrimeNumberMethod();
            Console.WriteLine("Enter a number to check it is prime or not");
            int num = int.Parse(Console.ReadLine());

            bool flag = s.IsPrime(num);

            

            
            

        }
    }
}
