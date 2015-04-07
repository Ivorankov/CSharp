namespace Animals
{
    using System;
    using Animals.Enumerators;
 
    public abstract class Animal : ISound
    {
        private int age;
        private Gender gender;
        private string name;
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age value cannot be less then or equal to 0!");
                }
                this.age = value;
            }
        }
        public Gender Gender
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Animal name cannot contain less then 3 symbols!");
                }
                this.name = value;
            }
        }
        public Animal(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }


        public abstract void MakeSound();

    }
}
