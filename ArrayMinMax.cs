using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class ArrayMinMax
    {
        public static void FindMinMax()
        {
            Console.WriteLine("enter total number of elements in an array: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[num];

            //Storing the elements in the array
            Console.WriteLine("enter elements in an array: ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Displaying the array
            for (int i = 0;i<num; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            //Finding min and max 

            int max = arr[0], min = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i] > max) { max = arr[i]; }
                if (arr[i] < min) { min = arr[i]; }
            }
            Console.WriteLine($"\nMin- {min}");
            Console.WriteLine($"Max- {max}");
        }
        static void Main(string[] args)
        {
            ArrayMinMax.FindMinMax();
        }
    }

}
