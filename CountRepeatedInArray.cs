using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class CountRepeatedInArray
    {
        public static void FindRepeated()
        {
            Console.WriteLine("Enter the size:");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[size];
            Console.WriteLine("Enter the elements:");
            for(int i=0; i<size; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            // Call the method to count and display the frequencies
            CountOccurrences(arr);

        }
        static void CountOccurrences(int[] arr)
        {
            // Create a dictionary to store the frequency of each number
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Traverse through the array and count occurrences
            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            // Display the results
            Console.WriteLine("Number | Frequency");
            Console.WriteLine("-------------------");
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key,-6} | {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
            CountRepeatedInArray.FindRepeated();
        }
    }
}
