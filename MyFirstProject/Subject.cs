using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Subject
    {
        static void Main(string[] args)
        {
            double total;
            double percentage;
            Console.WriteLine("Enter the Marks of Math :");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of english :");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of science :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of gk :");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of history :");
            int h = int.Parse(Console.ReadLine());
            total = m + e + s + g + h;
            percentage = total / 5;

            Console.WriteLine("Your percentage is: "+percentage+"%");
            
        }
    }
}
