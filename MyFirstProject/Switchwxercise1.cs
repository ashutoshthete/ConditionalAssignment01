using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Switchwxercise1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("opr( + , - , / , * )");
            char op = char.Parse(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("Addition="+num1+num2);
                    break;
                case '-':
                    Console.WriteLine( num1 - num2);
                    break;
                case '/':
                    Console.WriteLine("division=" + num1 / num2);
                    break;
                case '*':
                    Console.WriteLine("Multiplication=" + num1 + num2);
                    break;
            }




        }
    }
}
