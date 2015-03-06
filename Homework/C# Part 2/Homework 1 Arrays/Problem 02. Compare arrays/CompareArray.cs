using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer arrays from the console and compares them element by element.
namespace Problem_02.Compare_arrays
{
    class CompareArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program compares two arrays of int numbers");
            Console.Write("How many numbers do you want to put in the arrays?: ");
            int userLenght = int.Parse(Console.ReadLine());

            int[] intArray1 = new int[userLenght];
            int[] intArray2 = new int[userLenght];
            int i = 0;
            //This part will fill the arrays with numbers
            Console.WriteLine("Fill the first array with numbers(pressing Enter after each)");
            for (i = 0; i < userLenght; i++)
            {
                intArray1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fill the second array with numbers(pressing Enter after each)");
            for (i = 0; i < userLenght; i++)                                              
            {
                intArray2[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            //This part will compare the two arrays index by index(element)
            for (i = 0; i < userLenght; i++)
            {
                if (intArray1[i] == intArray2[i])
                {
                    Console.WriteLine("{0} is equal to {1}", intArray1[i], intArray2[i]);
                }
                else
                {
                    Console.WriteLine("{0} is not equal {1}", intArray1[i], intArray2[i]);
                }
            }
        }
    }
}
