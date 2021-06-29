using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class SwapNumbers
    {
        public static void GetInput()
        {
            Console.WriteLine("Enter the Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            SwapNumberWithTemp(a, b);
            SwapWithoutTemp(a, b);
        }
        public static void SwapNumberWithTemp(int a,int b)
        {
            Console.WriteLine("Before Swapping using Temp:");
            Console.WriteLine("The Two Numbers are [a: " + a + " b: " + b+" ]");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("The Two Numbers after swaping [a: " + a + " b: " + b+" ]");


        }
        public static void SwapWithoutTemp(int a, int b)
        {
            Console.WriteLine("Before Swapping using without Temp:");
            Console.WriteLine("The Two Numbers are [a: " + a + " b: " + b + " ]");
            a = a+b;
            b= a-b;
            a = a-b;
            Console.WriteLine("The Two Numbers after swaping [a: " + a + " b: " + b + " ]");

        }
    }
}
