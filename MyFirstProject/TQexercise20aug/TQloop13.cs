using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop13
    {
        static void Main(string[] args)
        {
            int pv = 0, pe = 1, trm, i, n=20;

            
            Console.Write("{0}    {1}", pv, pe);

            for (i = 3; i <= n; i++)
            {
                trm = pv + pe;
                Console.Write("  {0}  ", trm);
                pv = pe;
                pe = trm;
            }
            Console.Write("\n");
        }
    }
}
