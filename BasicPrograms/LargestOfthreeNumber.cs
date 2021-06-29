using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// Find the largest number among the three numbers.
    /// </summary>
    class LargestOfthreeNumber
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter the three Numbers:");
            int[] numbers = new int[3];
            for(int i = 0; i < 3; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                numbers[i] = a;
            }
            int result = (numbers[0] > numbers[1]) ? (numbers[0] > numbers[2] ? numbers[0] : numbers[2]) : (numbers[1] > numbers[2] ? numbers[1] : numbers[2]);
            Console.WriteLine("The largest number among [ " +numbers[0]+ " " +numbers[1]+ " "+numbers[2]+ " ] is "+result);
        }
    }
}
