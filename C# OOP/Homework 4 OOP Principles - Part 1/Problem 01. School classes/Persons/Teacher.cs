namespace Persons
{
    using System;
    using System.Collections.Generic;
    using School;
    using System.Text;
    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            private set { this.disciplines = value; }
        }
        public Teacher(string firstName,string lastName)
            : base(firstName,lastName)
        {

        }
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            foreach (var dis in Disciplines)
            {
                st.Append(dis.Name + "\nHours of lectures - " + dis.LecturesAmount + " Hours of exercises - " + dis.ExercisesAmount + "\n");
            }
            return string.Format("{0} {1} | Disciplines:\n{2}", FirstName, LastName, st);
        }
    }
}
