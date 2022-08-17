using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.Tqloop
{
    class loopex1
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                if ( i % 3 !=0)
                {
                    Console.WriteLine(i);
                }
                
                i++;
            }
        }
    }
}
