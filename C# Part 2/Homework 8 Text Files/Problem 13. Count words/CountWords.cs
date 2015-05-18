using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Write a program that reads a list of words from the file words.txt and finds 
//how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods
namespace Problem_13.Count_words
{
    class CountWords
    {
        static void Main()
        {
            string words = "../../Words.txt";
            string text = "../../Text.txt";
            string result = "../../Result.txt";
            try
            {
                //files are in 'bin/Debug' directory of the project
                List<string> wordsArray = File.ReadAllLines(words).ToList(); ;
                int[] counter = new int[words.Length];
                using (StreamReader readWords = new StreamReader(text))
                {
                    string line = readWords.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            counter[i] = counter[i] + Regex.Matches(line, "\\b" + words[i] + "\\b").Count;
                        }
                        line = readWords.ReadLine();
                    }
                }
                wordsArray.Sort();
                using (StreamWriter repeatedWords = new StreamWriter(result))
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        repeatedWords.WriteLine("{0}: {1}", words[i], counter[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
            }
            Console.WriteLine("Job done");
        }
    }
}
