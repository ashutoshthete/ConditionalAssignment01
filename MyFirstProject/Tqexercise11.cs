using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Your age : ");
            int yage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your friend's age : ");
            int fage = int.Parse(Console.ReadLine());

            Console.WriteLine("Hi Friends");

            if (fage < yage && yage > fage)
            {
                Console.WriteLine("Good morning");
            }else
            {
                Console.WriteLine("How are you");
            }
        }
    }
}
