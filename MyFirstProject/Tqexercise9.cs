using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age of person : ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("He/she is Teenager");
            }else if (age >= 18)
            {
                Console.WriteLine(" He/she is young person");
            }
        }
    }
}
