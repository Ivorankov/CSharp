namespace Bank
{
    using System;
    public class Company : Customer
    {
        public string CompanyName { get; private set; }
        public Company(string companyName)
        {
            this.CompanyName = companyName;
        }
    }
}
