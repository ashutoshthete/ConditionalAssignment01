using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop8
    {
        public static void Main(string[] args)
        {
            for(int x = 5; x >= 1; x--)
            {
                for(int y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for(int z = 1; z <= x; z++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}
