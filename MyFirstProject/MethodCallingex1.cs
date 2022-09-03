using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class MethodCallingex1
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome friends !");
        }
        public static void haveanice()
        {
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {
            welcome();
            haveanice();

        }
    }
    class MethodCallingex2
    {
        public static void Swap(ref int n1,ref int n2)
        {
            int newn = n1;
            n1 = n2;
            n2 = newn;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int num2 = int.Parse(Console.ReadLine());
            Swap(ref num1,ref num2);
            Console.WriteLine("now the first number in num1= " + num1 + "\nand the second number in num2=" +num2);
        }
    }
    class MethodCallingex3
    {
        public static int spacecount(String str)
        {
            int spc = 0;
            String str1;
            for(int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i,1);
                if (str1==" ")
                {
                    spc++;
                }
            }
            return spc;
        }
        public static void Main(string[] args)
        {
            string str2;
            Console.WriteLine("Input the string");
            str2 = Console.ReadLine();
            int r=spacecount(str2);
            Console.WriteLine(r);
            


        }
       
    }
   
}
