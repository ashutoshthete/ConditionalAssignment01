using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop10
    {
        public static void Main(string[] args)
        {
            
            int n = 1;

            for(int i = 1; i <= 10; i++)
            {
                n = ((i * i) + (i * i * i));
                Console.WriteLine(n);
            }
            
        }
    }
}
