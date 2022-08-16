using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Op2
    {
        public static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine(x++ + ++x - ++x + -x + x-- - x++ + x-- - x++ - --x + x++);

        }
    }
}
