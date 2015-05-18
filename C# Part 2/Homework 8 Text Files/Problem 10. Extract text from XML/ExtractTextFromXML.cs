using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from given XML file all the text without the tags.
namespace Problem_10.Extract_text_from_XML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            string currentLine;
            string textToExtract = null;
            int index;
            using (StreamReader reader = new StreamReader("../../TextFile.txt"))
            {
                currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    textToExtract = null;
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        if (currentLine[i] == '<')
                        {
                            index = currentLine.IndexOf('>', i);
                            i = index;
                        }
                        else
                        {
                            textToExtract += currentLine[i];
                        }
                    }
                    currentLine = reader.ReadLine();
                    Console.WriteLine(textToExtract);
                }
            }
        }
    }
}