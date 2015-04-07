namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Deposit : Account,IDepositable,IWithdrawable
    {
        public Deposit(Customer customer, decimal balance,double interestRate)
            :base(customer,balance,interestRate)
        {

        }


        public override decimal CalcInterest(int months)
        {
            if (this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.Balance*(1+(decimal)this.InterestRate * months);//got the formula from the net sue me if its incorrect :P 
            }
        }

        public void WithdrawCash(decimal money)
        {
            this.Balance -= money;
        }

        public void DepositCash(decimal money)
        {
            this.Balance += money;
        }
    }
}
