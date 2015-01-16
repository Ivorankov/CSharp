using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
namespace Problem_2.Gravitation_on_the_Moon
{
    class GravityCalcucaltor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight in kg");
            double weight = Convert.ToDouble(Console.ReadLine());
            weight = weight *0.17;
            Console.WriteLine("The weight on the moon will be " + weight+",kg");
        }
    }
}
