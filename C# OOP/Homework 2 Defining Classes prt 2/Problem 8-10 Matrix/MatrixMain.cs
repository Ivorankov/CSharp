
namespace Problem_8_10_Matrix
{
    using System;
    using System.Collections.Generic;
    class MatrixMain
    {
        static void Main(string[] args)
        {
            Matrix<int> test = new Matrix<int>(3, 3);
            Matrix<int> test2 = new Matrix<int>(3, 3);
            Console.WriteLine("First matrix has rows - " + test.Row + " And cols - " + test.Col);
            Console.WriteLine("First matrix has rows - " + test2.Row + " And cols - " + test2.Col);
            //Filling both matrixes with numbers
            Random number = new Random();
            for (int row = 0; row < test.Row; row++)
            {
                for (int col = 0; col < test.Col; col++)
                {
                    test[row, col] = number.Next(0,9);
                }
            }
            for (int row = 0; row < test2.Row; row++)
            {
                for (int col = 0; col < test2.Col; col++)
                {
                    test2[row, col] = number.Next(0,9);
                }
            }
            Console.WriteLine("This is the first matrix: ");
            Console.WriteLine(test.ToString());
            Console.WriteLine("This is the second matrix: ");
            Console.WriteLine(test2.ToString());
            var sumMatrix = test + test2;
            var subMatrix = test - test2;
            var multipMatrix = test * test2;
            Console.WriteLine("Testing the + operator");
            Console.WriteLine(sumMatrix.ToString());
            Console.WriteLine("Testing the - operator");
            Console.WriteLine(subMatrix.ToString());
            Console.WriteLine("Testing the * operator");
            Console.WriteLine(multipMatrix.ToString());
            Console.WriteLine("Testing the strange bool operator on the first matrix");
            var zeroElemet = test ? true : false;
            if (zeroElemet)
            {
                Console.WriteLine("Yes it contains AN 0!");
            }
            else
            {
                Console.WriteLine("No zero's here!");
            }
        }
    }
}
