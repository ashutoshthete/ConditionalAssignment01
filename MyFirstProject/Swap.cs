using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Swap
    {
        public static void Main(String[] args)
        {
            int a, b, SW;
            a = 15;
            b = 27;
            
            SW = a;
            a = b;
            b = SW;
            Console.WriteLine(" a=" + a + "  b="  +b);
        }
    }
}
