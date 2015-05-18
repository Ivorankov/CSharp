namespace Bank
{
    using System;
    public abstract class Account
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }
        public Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public abstract decimal CalcInterest(int months);
        
            
        
    }
}
