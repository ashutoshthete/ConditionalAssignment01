using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Switchwxercise3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            switch (num%2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                case 1:
                    Console.WriteLine("Odd");
                    break;

                
                    
                    
            }
        }
    }
}
