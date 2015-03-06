using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
namespace Homework_1_Arrays
{
    class ArrayAlocator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program allocates arrays, apparently \n");

            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}