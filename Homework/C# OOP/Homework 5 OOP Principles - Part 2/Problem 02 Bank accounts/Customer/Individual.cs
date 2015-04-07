namespace Bank
{
    using System;

    public class Individual : Customer
    {
                public Gender Gender  { get; private set; }
        public int Age { get; private set; }
        public Individual(Gender gernder,int age)
        {
            this.Gender = gernder;
            this.Age = age;
        }
    }
}
