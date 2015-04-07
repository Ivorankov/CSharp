namespace People
{
    using System;
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Workers gotta eat!Salary value cannot be less then or equal to 0!");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day cannot be less then or equal to 0 or be greater then 12!");
                }
                this.workHoursPerDay = value;
            }
        }
        public Worker(string firstName, string lastName,decimal weekSalary,int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);// 5 for the 5 work days in the week...
        }

    }
}
