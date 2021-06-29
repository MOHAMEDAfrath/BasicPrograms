using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    /// <summary>
    /// Program to check vowels and consonants.
    /// </summary>
    class VowelorConsonants
    {
        public static void CheckVowelOrConsonants()
        {
            Console.WriteLine("Enter the Alphabet:");
            Char alphabet = Convert.ToChar(Console.ReadLine());
            if (char.ToLower(alphabet) == 'a' || char.ToLower(alphabet) == 'e' || char.ToLower(alphabet) == 'i' ||  char.ToLower(alphabet) == 'o' || char.ToLower(alphabet) == 'u'){
                Console.WriteLine(alphabet+ " is a vowel");
            }
            else
            {
                Console.WriteLine(alphabet+ " is a consonant");
            }
        }
    }
}
