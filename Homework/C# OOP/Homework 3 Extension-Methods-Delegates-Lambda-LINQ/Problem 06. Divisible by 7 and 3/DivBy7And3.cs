
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace Problem_06.Divisible_by_7_and_3
{
    using System;
    using System.Linq;
    class DivBy7And3
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[100] ;
            for (int i = 0; i < 100; i++)
            {
                arrayOfNumbers[i] = i;
            }
            Console.WriteLine("Lambda test\n");
            var arrayLambda = arrayOfNumbers.Where(x => x % 3 == 0 && x % 7 == 0);
            foreach (var number in arrayLambda)                                   
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("\nLINQ test\n");
            var arrayLINQ =
                from number in arrayOfNumbers
                where number % 3 == 0 && number % 7 == 0
                select number;
            foreach (var number in arrayLINQ)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
