using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop1
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0 && i % 10 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
