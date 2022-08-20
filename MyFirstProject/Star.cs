using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Star
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter the rows");
            //int r = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Stars");
            //int s = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if(i==1||j==1||i==3||i==5)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j==5||i==3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");



            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j ==1 || j == 5 || i ==j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || j==5-2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i==3||i==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
