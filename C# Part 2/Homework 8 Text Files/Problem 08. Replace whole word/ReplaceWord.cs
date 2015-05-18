using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Modify the solution of the previous problem to replace only whole words (not strings).
namespace Problem_08.Replace_whole_word
{
    class ReplaceWord
    {
        static void Main()
        {
            string[] words = { "something", " ", "\r\n", "start", " start " };
            string fileName = "../../TextFile.txt";
            string resultFileName = "../../Result.txt";
            Random randomGenerator = new Random();
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.Write(words[randomGenerator.Next(words.Length)]);
                }
            }
            writer = new StreamWriter(resultFileName, false, Encoding.GetEncoding("windows-1251"));
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            string line;
            using (writer)
            {
                using (reader)
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"(\W|^)start(\W|$)", "$1finish$2"));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}