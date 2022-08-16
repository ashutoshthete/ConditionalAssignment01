using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Areainputoutput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Rectangle: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of Rectangle: ");
            int breadth = int.Parse(Console.ReadLine());

            int area = length * breadth;

            Console.WriteLine("The area of rectangle is : "+ area);
        }
    }
}
