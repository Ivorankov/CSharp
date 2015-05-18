namespace School
{
    using System;
    using System.Collections.Generic;
    public class School 
    {
        private string name;
        private string address;
        private string webSite;
        private List<Class> classes = new List<Class>();

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("Name of a school must contain at least 6 symbols");
                }
                this.name = value;
            }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string WebSite
        {
            get { return this.webSite; }
            set{this.webSite = value;}
        }
        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }
        public School(string name,string address, string webSite,List<Class> classes)
        {
            this.Name = name;
            this.Address = address;
            this.WebSite = webSite;
            this.Classes = classes;
        }
    }
}
