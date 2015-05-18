namespace Persons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Student : Person
    {
        private int classNumber;

        public int ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (value == -1)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be null");
                }
                this.classNumber = value;
            }
        }
        public Student(string firstName, string lastName, int classNumber)
            : base(firstName,lastName)
        {
            this.ClassNumber = classNumber;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} | Student number: {2}", FirstName, LastName, ClassNumber);
        }
    }
}
