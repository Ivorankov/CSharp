using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and lists all different
//words in the string along with information how many times each word is found.
namespace Problem_22.Words_count
{
    class Words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program counts words in sentences");
            string text = "Test sentences are used for test ing sentences word count count ing";

            string[] textSplit = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> resultLetters = new Dictionary<string, int>();// Yep its a copy/paste from problem 21...only char is replaced with string

            foreach (var key in textSplit)
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
            Console.WriteLine(string.Join("\n", resultLetters
                                    .Select(x => string.Format(@"{0} -> {1} times", x.Key, x.Value))
                                    .ToArray()));//Displays the contets of the dictionary
        }
    }
}
