namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Individual imACustomer = new Individual(Gender.Male,21);
            Company imACompanyCustomer = new Company("Tervelik");
            //Individual accounts
            Deposit depAcc = new Deposit(imACustomer, 1500.12m, 0.067);
            Mortgage morAcc = new Mortgage(imACustomer, 25000, 0.124);
            Loan loAcc = new Loan(imACustomer, 5600.14m, 0.097);
            //Company accounts
            Deposit depCAcc = new Deposit(imACompanyCustomer, 1500.12m, 0.067);
            Mortgage morCAcc = new Mortgage(imACompanyCustomer, 25000, 0.124);
            Loan loCAcc = new Loan(imACompanyCustomer, 5600.14m, 0.097);//Well our bank is a scam... 9.7% interest rate per month... xD

            Console.WriteLine("Individual account tests...");
            Console.WriteLine(depAcc.CalcInterest(18));
            Console.WriteLine(morAcc.CalcInterest(18));
            Console.WriteLine(loAcc.CalcInterest(18));
            Console.WriteLine("Company account tests...");
            Console.WriteLine(depCAcc.CalcInterest(18));
            Console.WriteLine(morCAcc.CalcInterest(18));
            Console.WriteLine(loCAcc.CalcInterest(18));
            
        }
    }
}
