using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Factorialmethodcalling
    {
        public int factorial(int n)
        {
            
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        public static void Main(string[] args)
        {
            Factorialmethodcalling p = new Factorialmethodcalling();
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int r = p.factorial(n);
            Console.WriteLine("The factorial of number is: "+r);
          
            
        }
    }
}
