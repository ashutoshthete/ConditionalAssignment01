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




            Console.WriteLine("\n");
            for (int r = 1; r <= 5; r++)
            {
                for(int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            for (int r = 1; r <=5 ; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


            int lines = 9;
            for(int r = 1; r <= lines; r++)
            {
                for (int space=1;space<=lines-r;space++) 
                {
                    Console.Write(" ");
                }
                for (int c=1;c<=r;c++) 
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j =i; j <=5 ; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            for (int c = 1; c <= 5; c++)
            {
                for (int j = c; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < c; k++)
                {
                    Console.Write("*");
                }
                for(int m = 1; m <= c; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            for(int c=1;c<=5 ;c++)
            {
                for(int r=c;r<=5 ;r++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            for(int c = 1; c <= 5; c++)
            {
                for(int r = 1; r <= c; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


           
        }
    }
}
