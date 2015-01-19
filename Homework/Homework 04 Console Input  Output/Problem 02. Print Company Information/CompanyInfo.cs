using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console
namespace Problem_02.Print_Company_Information
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName, address, webSite, managerFirstName,managerLastName;
            int companyPhone, companyFax, managerPhone;
            byte managerAge;
            Console.WriteLine("This program reads company info and prints it out");
            Console.WriteLine("so when you enter some information u get to see that information....wohooo");

            Console.Write("Enter the company name: ");
            companyName = Console.ReadLine();
            Console.Write("Enter the company's address: ");
            address = Console.ReadLine();
            Console.Write("Enter the company's phone number: ");
            while (!int.TryParse(Console.ReadLine(), out companyPhone))                                       //This part validates the user input
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Enter the company's fax number: ");
            while (!int.TryParse(Console.ReadLine(), out companyFax))
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Enter the company's webpage: ");
            webSite = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter information about the manager");
            Console.Write("First name of the manager: ");
            managerFirstName = Console.ReadLine();
            Console.Write("Last name of the manager: ");
            managerLastName = Console.ReadLine();
            Console.Write("Phone number of the manager: ");
            while (!int.TryParse(Console.ReadLine(), out managerPhone))
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Write("Age of the manager: ");
            while (!byte.TryParse(Console.ReadLine(), out managerAge))
            {
                Console.WriteLine("Please use numeric values");
            }
            Console.Clear();
            Console.WriteLine(companyName);                                                                //This part prints the information to the console
            Console.WriteLine(address);
            Console.WriteLine(companyPhone);
            Console.WriteLine(companyFax);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + ", age: " + managerAge + ", phone number: " + managerPhone);
        }
    }
}
