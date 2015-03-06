using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace Problem_18.Extract_e_mails
{
    class ExtractEMail
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will extract emails form texts");
            string text = "This is a test for the program. Write to us at happy@some.com or notmail@mail.net. We can also be found at ham@notAtallfake.com";

            string[] textSplit = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string checkTamplet = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

            List<string> emails = new List<string>();
            //Runst thru the textSplit array
            foreach (var item in textSplit)
            {
                if (Regex.IsMatch(item, checkTamplet))//regular expression to search for emails
                {
                    emails.Add(item);//if there are any they go in this list
                }
            }
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
