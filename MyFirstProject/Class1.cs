using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int x = a++ + b++ + c++;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = ++a - --b - c--;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = a-- - --b - c--;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = --c - --b - --a - a;
            Console.WriteLine(x + " " + a + " " + b + " " + c);
        }
    }
}
