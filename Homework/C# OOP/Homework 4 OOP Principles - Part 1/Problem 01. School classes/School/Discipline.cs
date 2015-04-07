namespace School
{
    using System;

    public class Discipline
    {
        private string name;
        private int lecturesAmount;
        private int exercisesAmount;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Discipline name must contain at least 4 symbols!");
                }
                this.name = value;
            }
        }
        public int LecturesAmount
        {
            get { return this.lecturesAmount; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException("Lectures must be at least 10 hrs");
                }
                this.lecturesAmount = value;
            }
        }
        public int ExercisesAmount
        {
            get { return this.exercisesAmount; }
            set
            {
                if (value < 5)
                {
                    throw new ArgumentOutOfRangeException("Exercises must be at least 5 hrs");
                }
                this.exercisesAmount = value;
            }
        }
        public Discipline(string name, int exercisesAmount, int lecturesAmount)
        {
            this.Name = name;
            this.LecturesAmount = lecturesAmount;
            this.ExercisesAmount = exercisesAmount;
        }
    }
}
