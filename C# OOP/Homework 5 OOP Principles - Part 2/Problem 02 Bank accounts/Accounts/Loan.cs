namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public override decimal CalcInterest(int months)
        {
            if (Customer is Company)
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (months - 2));
            }
            else
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (months - 3));
            }
        }

        public void DepositCash(decimal money)
        {
            this.Balance += money;
        }
    }
}
