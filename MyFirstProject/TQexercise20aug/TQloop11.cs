using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop11
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 50; i++)
            {
                
                    int val = i % 2 == 1 ? i * -1 : i;
                    Console.WriteLine(val);
                    
                
            }
        }
    }
}
