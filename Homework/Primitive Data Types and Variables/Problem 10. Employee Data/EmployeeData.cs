using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A marketing company wants to keep record of its employees
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
namespace ConsoleApplication1
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string FirstName = "Jezus";
            string LastName = "Christ";
            sbyte Age = 20;
            string Gender = "Male";
            long PersonalID = 1000000000;
            int EmployeeNumber = 10000000;

            Console.WriteLine("First Name: "+FirstName);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Gender: "+Gender);
            Console.WriteLine("Personal ID: "+PersonalID);
            Console.WriteLine("EmployeeNumber: "+EmployeeNumber);
        }
    }
}
