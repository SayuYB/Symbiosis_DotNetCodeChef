using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class StringAnagram
    {
        public static void ShowAnagram()
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine().ToLower();

            if (CheckAnagram(str1, str2))
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }
        static bool CheckAnagram(string str1, string str2)
        {
            // Remove any spaces and sort the characters in both strings
            char[] arr1 = str1.Replace(" ", "").ToCharArray();
            char[] arr2 = str2.Replace(" ", "").ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            // Compare the sorted character arrays
            return new string(arr1) == new string(arr2);
        }
        static void Main(string[] args)
        {
            StringAnagram.ShowAnagram();
        }
    }
}
