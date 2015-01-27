using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 
namespace Problem_4.Print_a_Deck_of_52_Cards
{
    class DeckOfCardsPrinter
    {
        static void Main(string[] args)
        {
            int i;
            string[] cards = new string[4] { "J", "Q", "K", "A" };
            string card;

            //This for loop will create the numbers 2-10
            for (i = 2; i <= 10; i++)
            {

                //This switch-case will start printing the cards to the console
                switch (i)
                {
                    case 2:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 3:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 4:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 5:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 6:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 7:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 8:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 9:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;
                    case 10:
                        Console.WriteLine(i + " of spades " + i + " of clubs " + i + " of hearts " + i + " of diamonds");
                        break;

                }
            }
            for (i = 0; i < 4; i++)
            {
                card = cards[i];
                switch (card)
                {
                    case "J":
                        Console.WriteLine(card + " of spades " + card + " of clubs " + card + " of hearts " + card + " of diamonds");
                        break;
                    case "Q":
                        Console.WriteLine(card + " of spades " + card + " of clubs " + card + " of hearts " + card + " of diamonds");
                        break;
                    case "K":
                        Console.WriteLine(card + " of spades " + card + " of clubs " + card + " of hearts " + card + " of diamonds");
                        break;
                    case "A":
                        Console.WriteLine(card + " of spades " + card + " of clubs " + card + " of hearts " + card + " of diamonds");
                        break;
                }
            }
        }
    }
}


