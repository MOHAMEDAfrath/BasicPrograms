using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class FactorProgram
    {
        /// <summary>
        /// Factors the method.
        /// </summary>
        public static void FactorMethod()
        {
            Console.WriteLine("Enter the value to find prime factor");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N % 2 == 0)
            {
                Console.Write(2 + " ");
                N /= 2;
            }

            for (int i = 3; i*i <= N; i++)
            {

                while (N % i == 0)
                {
                    Console.Write(i + " ");
                    N /= i;
                }
            }


            if (N > 2)
            {
                Console.Write(N);
            }
        }

    }
}
