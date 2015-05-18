using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
namespace Problem_09.Delete_odd_lines
{
    class DeleteOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../TextFile.txt");
            List<string> list = new List<string>();
            using (reader)
            {
                int lineNumber = 0;
                string lineOfText = reader.ReadLine();
                while (lineOfText != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0) 
                    {
                        list.Add(lineOfText);
                    }
                    lineOfText = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("../../TextFile.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
            Console.WriteLine("All odd lines have been removed(if u didnt check the txt file just add lines again...)");
        }
    }
}
