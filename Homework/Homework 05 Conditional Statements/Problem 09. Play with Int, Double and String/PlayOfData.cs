using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
namespace Problem_09.Play_with_Int__Double_and_String
{
    class PlayOfData
    {
        static void Main(string[] args)
        {
            int theInt;
            double theDouble;
            string userInput,case1;

            Console.WriteLine("This program recognises the data type of your input and then does usless stuff  with it");
            Console.Write("Write some text or a number: ");
            userInput = Console.ReadLine();
            //This part will recognise the data type of the user input.
            if (int.TryParse(userInput, out theInt))
            {
                case1 = "integer";
            }
            else if (double.TryParse(userInput, out theDouble))
            {
                case1 = "double";
            }
            else
            {
                case1 = "string";
            }
            switch (case1) // After we get a hit from one of the if's or the else, case1 is assigned that value and goes to the correct case.
            {
                case "integer":
                    theInt++;
                    Console.WriteLine("You've inputed an int number and now it will be increased by 1: " + theInt);
                    break;
                case "double":
                    theDouble = double.Parse(userInput);
                    theDouble++;
                    Console.WriteLine("You've inputed a double number and now it will be increased by 1: "+theDouble);
                    break;
                case "string":
                    Console.WriteLine("You've inputed a string and now a * will appear in the end: " + userInput + "*");
                    break;
            }
        }
    }
}
