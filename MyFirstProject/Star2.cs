using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Star2
    {
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                for(int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

           for(int r = 1; r <= 5; r++)
            {
                for(int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for(int r = 1; r <= 10; r++)
            {
                for(int c = r; c <= 10; c++)
                {
                    Console.Write(" ");
                }
                for(int d = 1; d <= r; d++)
                {
                    Console.Write("*");
                }
                for(int e = 1; e <= r; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for(int r = 1; r <= 5; r++)
            {
                for(int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
