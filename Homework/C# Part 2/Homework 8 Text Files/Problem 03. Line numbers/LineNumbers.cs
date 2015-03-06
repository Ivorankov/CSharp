using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
namespace Problem_03.Line_numbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter("../../wholeText.txt");
            StreamReader reader = new StreamReader("../../TextFile.txt");
            using (writer)
            {
                using (reader)
                {
                    int lineNumber = 1;
                    string lineOfText = reader.ReadLine();
                    while (lineOfText != null)
                    {
                        writer.WriteLine(lineNumber + " " + lineOfText);
                        lineOfText = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
            Console.WriteLine("Lines numbers are added (check the folder of the project)");
        }
    }
}
