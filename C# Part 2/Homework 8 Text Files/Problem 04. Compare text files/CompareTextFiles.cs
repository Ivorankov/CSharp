using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two text files line by line and prints the number
//of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
namespace Problem_04.Compare_text_files
{
    class CompareTextFiles
    {
        static void Main()
        {
            string lineOfText;
            int sameText = 0;
            int differentText = 0;
            using (StreamReader reader = new StreamReader("../../TextFile1.txt"), readerTwo = new StreamReader("../../TextFile2.txt"))
            {
                lineOfText = reader.ReadLine();
                string lineOfTheOtherText = readerTwo.ReadLine();
                while (lineOfTheOtherText != null)
                {
                    if (string.Compare(lineOfText, lineOfTheOtherText) == 0)
                    {
                        sameText++;
                    }
                    else
                    {
                        differentText++;
                    }
                    lineOfText = reader.ReadLine();
                    lineOfTheOtherText = readerTwo.ReadLine();
                }
            }
            Console.WriteLine("In the two texts there have {0} same lines \nand {1} different lines.", sameText, differentText);
        }
    }
}
