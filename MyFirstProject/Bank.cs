using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a five digit amount : ");
            int amt = int.Parse(Console.ReadLine());
            if (amt > 99999)
            {
                Console.WriteLine("INVALID AMOUNT. ");
            }
            else
            {
                
            }
        }
    }
}
