using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop6
    {
        public static void Main(string[] args)
        {
            for(int x = 1; x <= 4; x++)
            {
                for(int y = x; y < 4; y++)
                {
                    Console.Write(" ");
                }
                for(int z = 1; z < (x * 2); z++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}
