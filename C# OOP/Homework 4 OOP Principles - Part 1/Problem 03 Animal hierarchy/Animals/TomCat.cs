namespace Animals
{
    using System;
    using Animals.Enumerators;
    public class TomCat : Cat
    {
        public TomCat(string name, int age)
            :base(name,Gender.Male,age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Hey miao miao");
        }
    }
}
