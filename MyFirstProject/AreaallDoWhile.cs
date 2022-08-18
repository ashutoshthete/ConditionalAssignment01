using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class AreaallDoWhile
    {
        public static void Main(string[] args)
        {
            char ch;

            
                Console.WriteLine("Enter 1 to calculate area of circle");
                Console.WriteLine("Enter 2 to calculate area of square");
                Console.WriteLine("Enter 3 to calculte area of rectangle");
            do
            {
                int num = int.Parse(Console.ReadLine());
                

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Eneter radius of circle :");
                        double r = double.Parse(Console.ReadLine());
                        double ca = 3.14 * r * r;
                        Console.WriteLine("Area of circle is : " + ca);
                        break;
                    case 2:
                        Console.WriteLine("Enter side of square : ");
                        double side = double.Parse(Console.ReadLine());
                        double sa = side * side;
                        Console.WriteLine("Area of square is : " + sa);
                        break;
                    case 3:
                        Console.WriteLine("Enter lenght : ");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter breadth : ");
                        double br = double.Parse(Console.ReadLine());
                        double ra = l * br;
                        Console.WriteLine("Area of rectangle is : " + ra);
                        break;
                }
                Console.WriteLine("Do you wnat to continue.....");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y'||ch=='Y');
        }
    }
}
