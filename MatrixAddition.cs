using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class MatrixAddition
    {
        public static void AddMatrix()
        {
            //Take Row and Column size
            Console.WriteLine("Enter the row and col size: ");
            int row = Convert.ToInt32(Console.ReadLine()), cols = Convert.ToInt32(Console.ReadLine());

            // Input of First Matrix
            Console.WriteLine("--- Matrix 1 ---");

            int[,] matrix1 = new int[row, cols];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input of Second Matrix
            Console.WriteLine("--- Matrix 2 ---");

            int[,] matrix2 = new int[row, cols];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Addition of two matrix
            int[,] addMat = new int[row, cols];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    addMat[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("--- Addition of two matrix ---");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{addMat[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            MatrixAddition.AddMatrix();
        }
    }
}
