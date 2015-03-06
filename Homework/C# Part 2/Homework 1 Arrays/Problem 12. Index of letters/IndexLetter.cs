using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
namespace Problem_12.Index_of_letters
{
    class IndexLetter
    {
        static void Main(string[] args)
        {
            char[] letterArray = new char[26];
            char[] userArray = new char[] { };
            List<int> indexResults = new List<int>();
            char alphabet = 'A';

            Console.WriteLine("This program will take a word you enter and turnt it to strange index stuff");
            //This fills the char array with the english alphabet
            for (int i = 0; i < letterArray.Length; i++)
            {
                letterArray[i] = alphabet;
                alphabet++;
            }
            //This fills the userArray
            Console.Write("Please write a word: ");
            string userInput = Console.ReadLine().ToUpper();
            userArray = userInput.ToCharArray();

            //Here the magic happens
            int indexMax = letterArray.Length - 1;
            int indexMin = 0;
            int indexMiddle = indexMax - indexMin / 2;
            for (int i = 0; i < userArray.Length; i++)
            {
                while (indexMin <= indexMax)
                {
                    indexMiddle = (indexMin) + (indexMax - indexMin) / 2;
                    if (userArray[i] < letterArray[indexMiddle])
                    {
                        indexMax = indexMiddle - 1;
                    }
                    else if (userArray[i] > letterArray[indexMiddle])
                    {
                        indexMin = indexMiddle + 1;
                    }
                    if (userArray[i] == letterArray[indexMiddle])
                    {
                        break;
                    }
                }
                indexResults.Add(indexMiddle);//When we get a match from one of the indexes it goes in this list
                //After that the values of the indexes is reset for the next time they go in the while loop
                indexMax = letterArray.Length - 1;
                indexMin = 0;
                indexMiddle = indexMax - indexMin / 2;
            }

            //This part prints the result in the console
            int j = 0;
            Console.WriteLine("\nThis is the alphabet array");
            foreach (var letter in letterArray)
            {
                Console.Write("[{0}]={1}\n",j, letter);
                j++;
            }
            Console.WriteLine("\nThe letters in your word are at indexes: ");
            foreach (var result in indexResults)
            {
                Console.Write("[{0}]",result);
            }
            Console.WriteLine();
        }   
    }
}
