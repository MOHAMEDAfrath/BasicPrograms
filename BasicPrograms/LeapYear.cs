using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class LeapYear
    {
        /// <summary>
        /// Checks the leap year.
        /// </summary>
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year%4 == 0 && year%100 !=0) || year%100 == 0)
            {
                Console.WriteLine(year+" is a leap year!");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year!");
            }
        }

    }
}
