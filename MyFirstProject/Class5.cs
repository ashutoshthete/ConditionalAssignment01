using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Class5
    {
        public string ishappy(int num)
        {
            int r = num % 10;
            if(r%2==1)
            {
                return "happy"; 
            }
            else
            {
                return "not happy";
            }
            num = num / 10;
        }
        
        static void Main(string[] args)
        {
            Class5 c = new Class5();
            Console.WriteLine("enter");
            int num = int.Parse(Console.ReadLine());
            string r = c.ishappy(num);
            Console.WriteLine(r);

            
        }
    }
}
