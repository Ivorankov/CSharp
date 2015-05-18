using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
namespace Problem_03.Sequence_n_matrix
{
    class SequenceN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is called Sequence Monster");
            Console.WriteLine("It's just like the Cookie Monster but for sequences...:D");

            //This part takes the user input
            Console.Write("Please specify the number of rows: ");
            int userRow = int.Parse(Console.ReadLine());
            Console.Write("Please specify the number of cols: ");
            int userCol = int.Parse(Console.ReadLine());
            string[,] matrix = new string[userRow, userCol];





            //This part lets the user fill the matrix
            Console.WriteLine("Please fill the matrix");
            for (int i = 0; i < userRow; i++)
            {
                for (int j = 0; j < userCol; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = Console.ReadLine();

                }
            }
            Console.Clear();
            // This part checks the rows
            string mostCommon = String.Empty;
            int count = 0;
            int testCount = 0;
            for (int i = 0; i < userRow; i++)
            {
                for (int j = 1; j < userCol; j++)
                {
                    if (matrix[i, j - 1] == matrix[i, j])
                    {
                        count++;
                        if (testCount < count)
                        {
                            testCount = count; // testCount gets changed if a greater sequence is encounterd
                            mostCommon = matrix[i, j]; // and in mostCommon the given char, number, or text is stored
                        }
                    }
                }
                count = 0;
            }

            //This part checks the columns
            count = 0;
            for (int i = 0; i < userCol; i++)
            {
                for (int j = 1; j < userRow; j++)
                {
                    if (matrix[j - 1, i] == matrix[j, i])
                    {
                        count++;
                        if (testCount < count)
                        {
                            testCount = count;
                            mostCommon = matrix[j, i];
                        }
                    }
                }
                count = 0;
            }

            //This part checks the diagonal top left top bottom right
            for (int i = 0; i < userRow - 1; i++)
            {
                for (int j = 0; j < userCol - 1; j++)
                {
                    for (int row = i, col = j; row < userRow - 1 && col < userCol - 1; row++, col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                            if (testCount < count)
                            {
                                testCount = count;
                                mostCommon = matrix[j, i];
                            }
                        }
                    }
                    count = 0;
                }
                count = 0;
            }
            count = 0;
            // This part checks the diagonal top right to bottom left
            for (int i = 0; i < userRow - 1; i++)
            {
                for (int j = userCol - 1; j > 1; j--)
                {
                    for (int row = i, col = j; row < userRow - 1 && col < userCol - 1; row++, col--)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                            if (testCount < count)
                            {
                                testCount = count;
                                mostCommon = matrix[j, i];
                            }
                        }
                    }
                    count = 0;
                }
                count = 0;
            }

            //This prints the matrix in the console to make it easyer for the user
            Console.WriteLine("This is the matrix you created");
            for (int i = 0; i < userRow; i++)
            {
                for (int j = 0; j < userCol; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            //This part prints the result in the console
            if (testCount > 0)
            {
                Console.WriteLine("\nTHe most common errm whatever you wrote in the matrix(text, numbers or chars)");
                testCount++;
                Console.WriteLine("Is : ({0}) and there are {1} sightings of it in the matrix", mostCommon, testCount);
            }
            else
            {
                Console.WriteLine("I can't seem to find any sequences :(");
            }
        }
    }
}
