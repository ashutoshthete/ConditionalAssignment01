using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop3
    {
        static void Main(string[] args)
        {
            int i = 1;int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine(k+ "  "+i);


        }
    }
}
