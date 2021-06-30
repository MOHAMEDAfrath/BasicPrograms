using System;

namespace BasicPrograms
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programming!");
            while (true)
            {
                Console.WriteLine("Enter the Option");
                Console.WriteLine("1. Flip Coin");
                Console.WriteLine("2. Leap Year");
                Console.WriteLine("3. Power of two table");
                Console.WriteLine("4. Harmonic Number");
                Console.WriteLine("5. Prime Factorisation");
                Console.WriteLine("6. Quotient and Remainder.");
                Console.WriteLine("7. Swap Numbers");
                Console.WriteLine("8. Even or Odd");
                Console.WriteLine("9. Vowels and consonants");
                Console.WriteLine("10. Largest of three numbers");
                Console.WriteLine("11. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        FlipaCoin.HeadOrTail();
                        break;
                    case 2:
                        LeapYear.CheckLeapYear();
                        break;
                    case 3:
                        PowerOf2.Powerof2Table();
                        break;
                    case 4:
                        HarmonicNumber.HarmonicSeq();
                        break;
                    case 5:
                        FactorProgram.FactorMethod();
                        break;
                    case 6:
                        QuotientandRemainder.Division();
                        break;
                    case 7:
                        SwapNumbers.GetInput();
                        break;
                    case 8:
                        EvenorOdd.CheckEvenorOdd();
                        break;
                    case 9:
                        VowelorConsonants.CheckVowelOrConsonants();
                        break;
                    case 10:
                        LargestOfthreeNumber.LargestNumber();
                        break;
                    case 11:
                        return;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Option: ");
                        break;

                }
            }

        }
    }
}
