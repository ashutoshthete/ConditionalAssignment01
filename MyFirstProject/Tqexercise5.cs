using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("It is alphabet");
            } else if (ch >= '1' && ch <= '9')
            {
                Console.WriteLine("It is a digit");
            }
            else
            {
                Console.WriteLine("It is symbol");
            }
        }
    }
}
