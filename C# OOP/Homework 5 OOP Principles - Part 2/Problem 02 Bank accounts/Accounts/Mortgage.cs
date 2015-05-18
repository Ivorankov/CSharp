namespace Bank
{
    using System;

    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }



        public override decimal CalcInterest(int months)
        {
            if (Customer is Company)
            {
                //Calculates the total interest then subtracts from the total the lesser interest for the period (frist 12 months its half...)
                return this.Balance * (1 + (decimal)this.InterestRate * months) - (this.Balance * (1 + ((decimal)this.InterestRate*0.5m) * 12));
            }
            else
            {
                return this.Balance * (1 + (decimal)this.InterestRate * months) - (this.Balance * (1 + ((decimal)this.InterestRate * 6)));
            }
        }



        public void DepositCash(decimal money)
        {
            this.Balance += money;
        }
    }
}
