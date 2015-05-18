using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//    The first line in the input file contains the size of matrix N.
//    Each of the next N lines contain N numbers separated by space.
//    The output should be a single number in a separate text file.
namespace Problem_05.Maximal_area_sum
{
    class MaxSumArea
    {
        static void Main()
        {
            int areaOfMaxValue = int.MinValue;
            using (StreamReader reader = new StreamReader("../../TextFile.txt"))
            {
                int arrLength = reader.ReadLine().Length - 4;
                int[,] matrix = new int[arrLength, arrLength];
                string lineOfText = null;
                string[] numsForMatrix = null;
                for (int i = 0; i < arrLength; i++)
                {
                    lineOfText = reader.ReadLine();
                    numsForMatrix = lineOfText.Split(' ');
                    for (int j = 0; j < arrLength; j++)
                    {
                        matrix[i, j] = int.Parse(numsForMatrix[j]);
                    }
                }
                for (int i = 0; i < arrLength - 1; i++)
                {
                    for (int j = 0; j < arrLength - 1; j++)
                    {
                        if (matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > areaOfMaxValue)
                        {
                            areaOfMaxValue = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                        }
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("../../Result.txt"))
            {
                writer.WriteLine(areaOfMaxValue);
            }
            Console.WriteLine("Calculations completed check the project folder");
        }
    }
}