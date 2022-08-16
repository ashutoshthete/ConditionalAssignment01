using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Gainc
    {
        public static void Main(string[] args)
        {
            float buying_value = 27.50f;
            float selling_value = 28.60f;

            float gain = selling_value - buying_value;

            Console.WriteLine("The gain is : "+gain);
        }
    }
}
