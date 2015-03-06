using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
namespace Problem_19.Dates_from_text_in_Canada
{
    class DatesFromCanada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program extracts Canadian dates from texts");
            string text = "This is a test text made in 02.24.2015 . Spring will start 03.03.2015 and end 05.05.2015 .";

            string[] textSplit = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            DateTime tamplet = new DateTime();
            List<DateTime> dates = new List<DateTime>();

            //Runst thru the words in the array
            foreach (var item in textSplit)
            {
                if(DateTime.TryParseExact(item, "dd.MM.yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out tamplet))//Tryparse for the dates
                {
                    dates.Add(tamplet);
                }
                else
                {
                    continue;
                }
            }

            //Prints the result
            foreach (var date in dates)
            {
                Console.WriteLine(date.ToString("dd.MM.yyyy"));//Pulls the dates from the list
            }
        }
    }
}
