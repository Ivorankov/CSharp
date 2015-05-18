using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
namespace Problem_07.Replace_sub_string
{
    class ReplaceSubString
    {
        static void Main()
        {
            string[] words = {"some"," ", "\r\n", "start", " start " };
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
                        writer.WriteLine(line.Replace("start", "finish"));
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Finished (check the folder of the project)");
        }
    }
}