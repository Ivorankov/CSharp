using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
namespace Problem_02.Maximal_sum
{
    class MaxSum
    {
        public static Random numbers = new Random();
        static void Main(string[] args)
        {

            Console.WriteLine("This program finds the max 3x3 sum in a matrix");

            //This part takes the user input
            Console.Write("Please specify the number of rows: ");
            int userRow = int.Parse(Console.ReadLine());
            Console.Write("Please specify the number of cols: ");
            int userCol = int.Parse(Console.ReadLine());

            //This part fills the matrix with random numbers
            int[,] matrix = new int[userRow, userCol];
            for (int i = 0; i < userRow; i++)
            {
                for (int j = 0; j < userCol; j++)
                {
                    int currentNumber = numbers.Next(1, 10);
                    matrix[i, j] = currentNumber;
                }
            }
            // Prints the matrix for the user to see
            MatrixPrint(matrix, userRow, userCol);
            int maxSum;
            int startRow;
            int startCol;
            Sum(matrix, out maxSum, out startRow, out startCol);

            Console.WriteLine("The 3x3 cluster with max sum is located at indexes\n");
            for (int i = 0; i < 3; i++)
            {
                int tempCol = startCol;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("matrix[{0}, {1}] ", startRow, tempCol);
                    tempCol++;
                }
                Console.WriteLine();
                startRow++;
            }

            

        }

        public static void Sum(int[,] matrix, out int maxSum, out int startRow, out int startCol)
        {

            int currentSum = 0;
            maxSum = 0;

            startRow = 0;
            startCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }
        public static void MatrixPrint(int[,] matrix, int row, int col)
        {
            int i = row;
            int j = col;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}