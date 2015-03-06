using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
namespace Problem_24.Order_words
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts words");
            Console.WriteLine("Write some words separated by (space)");

            string[] userWords = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(userWords);
            foreach (var word in userWords)
            {
                Console.Write("{0} ", word);
            }
        }
    }
}
