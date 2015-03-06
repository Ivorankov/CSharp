using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below:
namespace Problem_1.Fill_the_matrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            Random numbers = new Random();
            Console.WriteLine("This program fills a matrix with random numbers");

            //This part takes the user input
            Console.Write("Please specify the size of the matrix: ");
            int userInput = int.Parse(Console.ReadLine());
            int[,] matrix = new int[userInput,userInput];

            //This part fills the matrix with random numbers
            for (int i = 0; i < userInput; i++)
            {
                for (int j = 0; j < userInput; j++)
                {
                    int currentNumber = numbers.Next(1,10);
                    matrix[i, j] = currentNumber;
                }
            }

            //This part prints the matrix
            for (int i = 0; i < userInput; i++)
            {
                for (int j = 0; j < userInput; j++)
                {
                    Console.Write("{0} ",matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
