using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that concatenates two text files into another text file.
namespace Problem_02.Concatenate_text_files
{
    class ConcatTextFiles
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("../../ConcatedText.txt");
            StreamReader reader = new StreamReader("../../TextFile1.txt");
            using (writer)
            {
                using (reader)
                {
                    string lineOfText = reader.ReadLine();
                    while (lineOfText != null)
                    {
                        lineOfText = reader.ReadLine();
                        writer.WriteLine(lineOfText);
                    }
                }
                reader = new StreamReader("../../TextFile2.txt");
                using (reader)
                {
                    string lineOfText = reader.ReadLine();
                    while (lineOfText != null)
                    {
                        lineOfText = reader.ReadLine();
                        writer.WriteLine(lineOfText);
                    }
                }
            }
            Console.WriteLine("Job done");
        }
    }
}
