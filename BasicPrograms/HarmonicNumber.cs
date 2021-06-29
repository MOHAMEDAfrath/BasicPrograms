using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// Program to print harmonic Number series and sum
    /// </summary>
    class HarmonicNumber
    {
        public static void HarmonicSeq()
        {
            Console.WriteLine("Enter the Nth Value: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            Console.Write("[ ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write("1/" + i + " ");
                sum += (double)1 / i;
                
            }
            Console.Write("] = ");

            Console.WriteLine(Math.Round(sum,2));

        }
    }
}
