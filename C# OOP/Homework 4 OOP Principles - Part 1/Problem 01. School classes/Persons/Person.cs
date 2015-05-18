namespace Persons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Person : IComment
    {
        private string firstName;
        private string lastName;
        private List<string> comments;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must contain at least 3 symbols");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must contain at least 3 symbols");
                }
                this.lastName = value;
            }
        }
        public List<string> Comments
        {
            get { return this.comments; }
            set
            {
                this.comments = value;
            }
        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
