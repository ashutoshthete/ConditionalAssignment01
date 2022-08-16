using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Testexercise2
    {
        public static void Main(string[] args)
        {
            double total;
            double percentage;
            double average;
            Console.WriteLine("Math marks:");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("english marks:");
            int english = int.Parse(Console.ReadLine());
            Console.WriteLine("physics marks:");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("chemistry marks:");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("biology marks");
            int biology = int.Parse(Console.ReadLine());

            total = math + english + physics + chemistry + biology;
            percentage = total / 5;

            Console.WriteLine("total="+total+" percentage="+percentage);
        }
    }
}
