using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
namespace Problem_23.Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program removes unnessessseryyyy letters");
            Console.Write("Write some letters (ex. aaddddvvggg): ");
            string userLetters = Console.ReadLine();
            char previous = userLetters[0];
            string result = string.Empty;
            result += userLetters[0];
            for (int i = 1; i < userLetters.Length; i++)
            {
                if (userLetters[i-1] != userLetters[i])
                {
                    result += userLetters[i];//only the first letter isn't added
                } 
            }
            Console.WriteLine(result);
        }
    }
}
