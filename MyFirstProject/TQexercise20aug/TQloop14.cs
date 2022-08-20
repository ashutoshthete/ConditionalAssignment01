using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int Sum = 0;
            int f = 1;
            
            for (int i = 1; i <= n; i++)
            {

                f = f * i;
                Sum += f;
            }
            Console.WriteLine(Sum);

        }




    }
    
        
}
