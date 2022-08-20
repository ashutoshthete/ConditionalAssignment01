using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01.TQexercise20aug
{
    class TQloop5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int flag = 0;
            int cube = num * num * num;

            while (num !=0)
            {
                if (num % 10 != cube % 10)
                {
                    flag = 1;
                    break;
                }
                num = num / 10;
                cube = cube / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("it is trimorphic number.");
            }
            else
            {
                Console.WriteLine("it's not trimorphic number.");
            }
           


            
          
        }
    }
}
