using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class FlipaCoin
    {
        public static void HeadOrTail()
        {
            int head = 0;
            int tail = 0;
            Random random = new Random();
            Console.WriteLine("Enter the number of Flips:");
            int noOfFlips = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfFlips; i++)
            {
                double flip = (double)random.NextDouble();
                if (flip > 0.5)
                {
                    head++;

                }
                else
                {
                    tail++;
                }
            }
                Console.WriteLine("No Of Heads : " + head);
                Console.WriteLine("No Of Tails : " + tail);
                double headPercent= (double)head/noOfFlips *100;
                double tailPercent = (double)tail/noOfFlips *100 ;
                Console.WriteLine("Head Percentage : "+headPercent);
                Console.WriteLine("Tail Percentage : "+tailPercent);
            
        }

    }

}
