using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Calculatorswitch
    {
        static void Main(string[] args)
        {
            double a, b, result = 0;

            Console.WriteLine("Enter the first number : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose the operand:(+,-,*,/): ");
            char operand = char.Parse(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }
            Console.WriteLine(""+a + " " +operand+ " " + b + "\n =" + result);
        }
    }
}
