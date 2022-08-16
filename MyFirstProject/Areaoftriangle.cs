using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Areaoftriangle 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of triangle : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle : ");
            int h = int.Parse(Console.ReadLine());
            double areaoftriangle = (b * h) / 2;

            Console.WriteLine("Area of triangle is : " + areaoftriangle);

        }
    }
}
