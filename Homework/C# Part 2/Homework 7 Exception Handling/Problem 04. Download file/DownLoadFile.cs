using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
namespace Problem_04.Download_file
{
    class DownLoadFile
    {
        static void Main(string[] args)
        {

            using (WebClient downloadClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Starting the download process");
                    downloadClient.DownloadFile("http://www.tehcute.com/pics/201110/marshmellow-kitten-big.jpg", "DownloadedPic.jpg");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.Beep();
                    Console.WriteLine("Your picture has been downloaded!");
                    Console.WriteLine("It can be found it the Bin folder of the project");
                }
            }
        }
    }
}

