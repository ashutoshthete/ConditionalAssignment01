using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int num = int.Parse(Console.ReadLine());


            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine("The number is divisible ");
            }
            else
            {
                Console.WriteLine("The number is not divisible ");
            }
        }
    }
}
