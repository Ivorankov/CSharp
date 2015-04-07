using System;

namespace People
{
    public class Student : Human
    {
        private double grade;
        public double Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade value cannot be less then 2 or greater then 6!");
                }
                this.grade = value;
            }
        }
        public Student(string firstName,string lastName, double grade)
            :base(firstName,lastName)
        {
            this.Grade = grade;
        }
    }
}
