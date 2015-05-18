using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Extend the previous program to support also subtraction and multiplication of polynomials
namespace Problem_12.Subtracting_polynomials
{
    class SubtractPoly
    {
        static void Main(string[] args)
        {
            List<int> results = new List<int>();
            Console.WriteLine("This program adds two polynoms");

            //In this part I set the values
            string first = "1x2 ";
            string second = "5";
            string third = "4x2";
            string fourth = "3x2";
            //This part calls the methond and fills the result list
            results = SimplifyCoefficients(first, second);
            Console.WriteLine("x2 - 5 => ");
            foreach (var index in results)
            {
                Console.Write("{0} ", index);
            }
            Console.WriteLine("\n4x2 - 3x2 => ");
            results = SimplifyCoefficients(third, fourth);
            foreach (var index in results)
            {
                Console.Write("{0} ", index);
            }
            Console.WriteLine();
        }
        static List<int> SimplifyCoefficients(string first, string second)
        {
            List<int> resultCoef = new List<int>();//This list will hold the coefficients

            string firstNumber = new String(first.TakeWhile(Char.IsDigit).ToArray());//Takes the number in front of x
            int coefFirst = int.Parse(firstNumber);
            string poly1 = first.Remove(0, firstNumber.ToString().Length);//This cuts out the number in front of x 

            string secondNumber = new String(second.TakeWhile(Char.IsDigit).ToArray());
            int coefSecond = int.Parse(secondNumber);
            string poly2 = second.Remove(0, coefSecond.ToString().Length);

            string result = string.Empty;
            if (poly1 == poly2)//if both are of equal pow and type (x2 and x2)
            {
                int sum = coefFirst - coefSecond;
                resultCoef.Add(sum);
                return resultCoef;
            }
            else
            {
                if (Regex.IsMatch(first, @"x"))//Checks if there are any x's mixed in with the number
                {
                    int pow = int.Parse(first.Remove(0, firstNumber.ToString().Length + 1));//gets the pow value (x2 => 2)
                    while (pow > 0)
                    {
                        resultCoef.Add(coefFirst);
                        pow--;
                        coefFirst--;
                        if (coefFirst < 0)
                        {
                            coefFirst = 0;
                        }
                    }
                }
                else
                {
                    resultCoef.Add(coefFirst);
                }

                if (Regex.IsMatch(second, @"x"))
                {
                    int pow2 = int.Parse(second.Remove(0, secondNumber.ToString().Length + 1));
                    while (pow2 > 0)
                    {
                        resultCoef.Add(coefSecond);
                        pow2--;
                        if (coefSecond < 0)
                        {
                            coefSecond = 0;
                        }
                    }
                }
                else
                {
                    resultCoef.Add(coefSecond);
                }
                resultCoef.Reverse();//Because thats how its shown in the example, doesn't make sence but...
                //takes the number in front of x
                return resultCoef;
            }
        }
    }
}