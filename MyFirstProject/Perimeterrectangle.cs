using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Perimeterrectangle
    {
        public static void Main(string[] args)
        {
            int l, b, total;
            Console.WriteLine("Enter the length");
             l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
             b = int.Parse(Console.ReadLine());

            total = 2 * (l + b);

            Console.WriteLine("The perimeter of rectangle = "+total);
        }
    }
}
