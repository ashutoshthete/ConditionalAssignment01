using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Sellingprice
    {
        public static void Main(string[] args)
        {
            float cprice = 1.0F;
            int noitems = 20;
            float profit = 100.0F;
            float sp = 0;
            sp = ((100 + profit) / 100) * cprice;
            Console.WriteLine(sp);

            //for (noitems = 1; noitems <= 20; noitems++)
            //{
                
              //  Console.WriteLine(noitems+" ="+sp);
            //}

            
        }   
    }
}
