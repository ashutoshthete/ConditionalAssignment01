using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Area_all
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to calculate area of circle");
            Console.WriteLine("Enter 2 to calculate area of square");
            Console.WriteLine("Enter 3 to calculate area of area of right angled triangle");
            Console.WriteLine("Enter 4 to calculte area of rectangle");
            Console.WriteLine("Enter 5 to calculate circumference of a circle of a square");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Eneter radius of circle :");
                    double r = double.Parse(Console.ReadLine());
                    double ca = 3.14 * r * r;
                    Console.WriteLine("Area of circle is : "+ca);
                    break;
                case 2:
                    Console.WriteLine("Enter side of square : ");
                    double side = double.Parse(Console.ReadLine());
                    double sa = side * side;
                    Console.WriteLine("Area of square is : " +sa);
                    break;
                case 3:
                    Console.WriteLine("Enter base of right triangle : ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height of right triangle : ");
                    double h = double.Parse(Console.ReadLine());
                    double rta = (1 / 2) * b * h;
                    Console.WriteLine("Area of right angled triangle is : " +rta);
                    break;
                case 4:
                    Console.WriteLine("Enter lenght : ");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter breadth : ");
                    double br = double.Parse(Console.ReadLine());
                    double ra = l * br;
                    Console.WriteLine("Area of rectangle is : " +ra);
                    break;

                case 5:
                    Console.WriteLine("Enter radius:");
                    double radius = double.Parse(Console.ReadLine());
                    double coc = 2 * (3.14) * radius;
                    Console.WriteLine("Circumference of circle is : " +coc);
                    break;
                default:
                    Console.WriteLine(".....ERROR.....");
                    break;

            }
        }
    }
}
