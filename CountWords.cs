using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class CountWords
    {
        public static void countWords()
        {
            Console.WriteLine("Enter the String:");
            string word = Console.ReadLine();

            //Checking if string is null or not
            if(string.IsNullOrEmpty(word))
            {
                Console.WriteLine("there are 0 words.");
            }
            
            //Separating words by using whitespaces
            string[] wordArr= word.Split(' ');

            //Using Length to count words in an array
            Console.WriteLine($"{word}\n contains {wordArr.Length} words.");
        }
        static void Main(string[] args)
        {
           CountWords.countWords();
        }
    }
}
