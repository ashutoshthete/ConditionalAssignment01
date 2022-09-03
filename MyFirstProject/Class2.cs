using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class2
    {
        public int firstdigit(int num)
        {
            
            while (num >= 10)
            {
                 num = num / 10;
            }
            return num;
        }
        public int lastdigit(int num)
        {
            int r = num % 10;
            return r;
        }
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            Console.WriteLine("enter");
            int num = int.Parse(Console.ReadLine());
            int result = c2.firstdigit(num);
            int r2 = c2.lastdigit(num);
            Console.WriteLine("first  "+result+"\nlast  "+r2);
            
        }
    }
}
