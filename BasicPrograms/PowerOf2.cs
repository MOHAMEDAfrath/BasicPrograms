using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// to print power of 2 table
    /// </summary>
    class PowerOf2
    {
        public static void Powerof2Table()
        {
            Console.WriteLine("Enter the value of power: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("2 ^ " + i + " = " +Math.Pow(2,i));
            }
        }
    }
}
