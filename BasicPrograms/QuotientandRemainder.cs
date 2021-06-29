using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// To find quotient and remainder.
    /// </summary>
    class QuotientandRemainder
    {
        public static void Division() 
        {
            Console.WriteLine("Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Quotient is "+dividend / divisor);
            Console.WriteLine("The Remainder is " +dividend % divisor);

        }
    }
}
