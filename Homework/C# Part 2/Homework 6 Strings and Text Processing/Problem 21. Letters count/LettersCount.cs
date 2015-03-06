using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 
namespace Problem_21.Letters_count
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program counts letters in words");
            Console.Write("Write some word: ");
            string userWord = Console.ReadLine();

            char[] letters = userWord.ToCharArray();
            Dictionary<char,int> resultLetters = new Dictionary<char,int>();

            foreach (var key in letters)
            {
                if (Char.IsLetter(key))
                {
                    if (!resultLetters.ContainsKey(key))
                    {
                        resultLetters.Add(key, 1);
                    }
                    else
                    {
                        resultLetters[key]++;
                    }
                }
            }
               Console.WriteLine(string.Join("\n", resultLetters
                                       .Select(x => string.Format(@"{0} -> {1} times", x.Key, x.Value))
                                       .ToArray()));//Displays the contets of the dictionary
        }
    }
}

