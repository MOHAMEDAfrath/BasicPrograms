using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// Checks whether the number is even or Odd
    /// </summary>
    class EvenorOdd
    {
        public static void CheckEvenorOdd()
        {
            Console.WriteLine("Enter the  number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine(number+" is even number.");
            }
            else
            {
                Console.WriteLine(number + " is Odd number.");

            }
        }
    }
}
