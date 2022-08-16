using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Cubeinputoutput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer : ");
            int i = int.Parse(Console.ReadLine());

            int sum = i * i * i;
            Console.WriteLine("The cube of integer is : " + sum);

        }


    }
}