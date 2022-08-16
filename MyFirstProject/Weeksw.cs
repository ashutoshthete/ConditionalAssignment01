using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Weeksw
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of day you want to print : ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("monday"); 
                    break;
                case 2:
                    Console.WriteLine("TUesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday it's Holiday");
                    break;
                default:
                    Console.WriteLine("Error\nDay does not exist. ");
                    break;
            }
        }
    }
}
