using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Testexercise1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of triangle");
            float side = float.Parse(Console.ReadLine());
            double area = (1.73 * side * side) / 4;
            Console.WriteLine("area of euilateral triangle is : " + area);
        }
    }
}
