using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class InputJaggedArr
    {
        public static void EnterJaggedArr()
        {
            Console.WriteLine("Enter the size for jagged Array: ");
            int size=Convert.ToInt32(Console.ReadLine());

            int[][] arr= new int[size][];

            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the number of columns for row {i + 1}:");
                int col = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[col];

                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"Enter element [{i}, {j}]:");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Jagged Array- ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            InputJaggedArr.EnterJaggedArr();
        }
    }
}
