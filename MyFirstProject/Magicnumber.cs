using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Magicnumber
    {
        static void Main(string[] args)
        
        {
            int gnumber = 43;

           
            while (true)
            {
                Console.WriteLine("enter the number:");
                int num = int.Parse(Console.ReadLine());
                if (num > gnumber)
                {
                    Console.WriteLine("The number is greater Try again");
                    continue;
                }else if (num < gnumber)
                {
                    Console.WriteLine("The number is smaller Try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Guess number is Correct Congratulations.....");
                    break;
                }
            }
        }
    }
}
