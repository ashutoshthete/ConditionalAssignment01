using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int lar = 0;
            int smal = 9;
            int altsum = 0;
            while( n != 0){
                int r = n % 10;
                lar = Math.Max(r, lar);
                smal = Math.Min(r, smal);
                n = n / 10;
               
               

            }
            
            Console.WriteLine("the largest="+lar+" the smallest="+smal);
        }
    }


}   
