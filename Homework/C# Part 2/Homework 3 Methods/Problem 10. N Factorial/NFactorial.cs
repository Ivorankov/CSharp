using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
namespace Problem_10.N_Factorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh no , not Nfactorial again!");
            //This part takes the user input
            Console.Write("To what number do you want to ermmm do the n-factorial magic?: ");
            int userNumber = int.Parse(Console.ReadLine());

            NFactorialCalc(userNumber);//Calls the method


        }
        static void NFactorialCalc(int number)
        {
            int[] array = new int[number];
            BigInteger result = 1;
            int numberInArray = number;
            for (int i = 0; i < number; i++)//Puts all the numbers from 1 to int number in an array
            {
                array[i] = numberInArray;
                numberInArray--;
            }
            foreach (var item in array)//Does the nfactorialing? if thats how its called
            {
                result *= item;
            }
            Console.WriteLine("The nFactorial is: " + result);
        }
    }
}
