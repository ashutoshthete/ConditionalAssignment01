using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int altsum = 0;
            int r;
            int odd = 0;
            while (num > 0)
            {
                r = num % 10;
                if (r % 2 == 1)
                {
                    odd++;
                }
                num = num / 10;
            }
            Console.WriteLine(odd);
            if (odd % 2 == 1)
            {
                Console.WriteLine( );
            }
        }
    }
}
