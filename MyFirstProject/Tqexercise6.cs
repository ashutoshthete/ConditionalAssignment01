using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Tqexercise6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number third number:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The largest number is :"+num1);
            }else if(num2>=num1 && num2 >= num3)
            {
                Console.WriteLine("The largest number is :" + num2);
            }else if(num3>=num1 && num3 >= num2)
            {
                Console.WriteLine("The largest number is :" + num3);
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
           
            
        }
    }
}
