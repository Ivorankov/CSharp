using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
namespace Problem_03.Read_file_contents
{
    class ReadFileContent
    {
        static void Main(string[] args)
        {
            // ..\..\Content.txt (copy paste this(exactly like you see it) and keep your fingers crossed!
            Console.WriteLine("Write the file path: ");
            string filePath = Console.ReadLine();
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("The content of the file");
                Console.WriteLine(fileContent);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
            catch (PathTooLongException ptlex)
            {
                Console.WriteLine(ptlex.Message);
            }
            catch (DirectoryNotFoundException dnfex)
            {
                Console.WriteLine(dnfex.Message);
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
            catch (UnauthorizedAccessException uaex)
            {
                Console.WriteLine(uaex.Message);
            }
            catch (NotSupportedException nsex)
            {
                Console.WriteLine(nsex.Message);
            }
        }
    }
}
