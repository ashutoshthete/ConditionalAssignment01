using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Interest
    {
        static void Main(String[] args)
        {
            double p, r, t, si;
            Console.WriteLine("enter the amount = ");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the interest rate=");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("enter time = ");
            t = double.Parse(Console.ReadLine());


            si = p * r * t / 100;
            Console.WriteLine("the simple interest is = " +si);
        }
    }
}
