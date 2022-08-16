using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Employeesalary
    {
        static void Main(string[] args)
        {
            double basicsalary, gross, hra, Da;
            Console.WriteLine("Enter the basic salary: ");
            int bs = int.Parse(Console.ReadLine());
            if (bs <= 10000) 
            {
                hra = bs * 0.20;
                Da = bs * 0.80;
            }else if (bs<= 20000)
            {
                hra = bs * 0.25;
                Da = bs * 0.90;
            }
            else 
            {
                hra = bs * 0.30;
                Da = bs * 0.95;
            }
            gross = hra + Da;
            Console.WriteLine("The gross salry is : "+gross);
               

        }
    }
}
