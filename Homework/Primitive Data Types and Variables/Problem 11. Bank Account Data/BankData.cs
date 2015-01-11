using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
namespace Problem_10.Employee_Data
{
    class BankData
    {
        static void Main(string[] args)
        {
            string FirstName, MiddleName, LastName, BankName, IBAN;
            decimal AccountBalancetot, AccountBalance1, AccountBalance2, AccountBalance3;
            ulong CreditCard1, CreditCard2, CreditCard3;
            bool tester;

            Console.WriteLine("Welcome to BankSoft 2.0");
            Console.WriteLine("Please enter bank account information");
            Console.WriteLine("------------------------");
            Console.WriteLine("Fist name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Middle name:");
            MiddleName = Console.ReadLine();
            Console.WriteLine("Last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Name of the Bank");
            BankName = Console.ReadLine();
            Console.WriteLine("IBAN");
            IBAN = Console.ReadLine();
            IBAN = IBAN.ToUpper();
            Console.WriteLine("------------------------");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Credit card №1 number");
             do
            {
                tester = UInt64.TryParse(Console.ReadLine(), out CreditCard1);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);

            Console.WriteLine("Ammount of money in card");
            do
            {
                tester = Decimal.TryParse(Console.ReadLine(), out AccountBalance1);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);

            Console.WriteLine("------------------------");
            Console.WriteLine("Credit card №2 number");
            do
            {
                tester = UInt64.TryParse(Console.ReadLine(), out CreditCard2);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);
            Console.WriteLine("Ammount of money in card");
            do
            {
                tester = Decimal.TryParse(Console.ReadLine(), out AccountBalance2);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);
            Console.WriteLine("------------------------");

            Console.WriteLine("Credit card №3 number");
            do
            {
                tester = UInt64.TryParse(Console.ReadLine(), out CreditCard3);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false); ;
            Console.WriteLine("Ammount of money in card");
            do
            {
                tester = Decimal.TryParse(Console.ReadLine(), out AccountBalance3);
                if (tester)
                {
                }
                else
                {
                    Console.WriteLine("Ivalid entry, please use numbers");
                }
            } while (tester == false);

            AccountBalancetot = AccountBalance1 + AccountBalance2 + AccountBalance3;
            Console.WriteLine("------------------------");
            Console.WriteLine(FirstName + " " + MiddleName + " " + LastName);
            Console.WriteLine("");
            Console.WriteLine(BankName);
            Console.WriteLine(IBAN);
            Console.WriteLine("");
            Console.WriteLine("Credit card 1 Number: " + CreditCard1 + "| Balance: " + AccountBalance1 + "$");
            Console.WriteLine("Credit card 2 Number: " + CreditCard2 + "| Balance: " + AccountBalance2 + "$");
            Console.WriteLine("Credit card 3 Number: " + CreditCard3 + "| Balance: " + AccountBalance3 + "$");
            Console.WriteLine("");
            Console.WriteLine("Total bank account balance: " + AccountBalancetot + "$");
        }
    }
}
