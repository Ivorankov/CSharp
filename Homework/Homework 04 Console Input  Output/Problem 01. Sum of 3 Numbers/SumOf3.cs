﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads 3 real numbers from the console and prints their sum.
namespace Problem_01.Sum_of_3_Numbers
{
    class SumOf3
    {
        static void Main(string[] args)
        {
            int first, second, third, result;

            Console.WriteLine("This program will sum 3 numbers...");
            Console.Write("Please enter the 1st number: ");
            while (!int.TryParse(Console.ReadLine(),out first))                                              //This will validate the user input
            {
                Console.WriteLine("Stop trying to crash the program so u can bitch about it in the forums!");
            }

            Console.Write("Please enter the 2nd number: ");
            while (!int.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Stop trying to crash the program so u can bitch about it in the forums!");
            }

            Console.Write("Please enter the 3rd number: ");
            while (!int.TryParse(Console.ReadLine(), out third))
            {
                Console.WriteLine("Stop trying to crash the program so u can bitch about it in the forums!");
            }

            result = first + second + third;                                                               //This sums the 3 numbers
            Console.WriteLine("The sum of the 3 numbers is: " + result);                                   //This prints the sum into the console
        }
    }
}
