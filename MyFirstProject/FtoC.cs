using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class FtoC
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in farehnite : ");
            int fahrehnite = int.Parse(Console.ReadLine());
            
            int celcius = (fahrehnite - 32) * 5 / 9;
            Console.WriteLine("\n"+celcius+" degree celcius");
        }
    }
}
