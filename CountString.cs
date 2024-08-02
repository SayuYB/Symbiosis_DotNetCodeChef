using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class CountString
    {
        public static void CountAlpha()
        {
            int vowels = 0, consonant = 0;
            string alpha;
            Console.WriteLine("Enter the String (in lowercase)- ");
            alpha = Console.ReadLine();

            //Checking for the vowels and consonants and counting them.
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] == 'a' || alpha[i] == 'e' || alpha[i] == 'i' || alpha[i] == 'o' || alpha[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonant++;
                }
            }
            Console.WriteLine($"Total Number of alphabet in {alpha}: {alpha.Length} ");
            Console.WriteLine($"Number of Vowels in {alpha}: {vowels}");
            Console.WriteLine($"Number of Consonant in {alpha}: {consonant}");
        }
        static void Main(string[] args)
        {
            CountString.CountAlpha();
        }
    }

}
