using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); 

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            //deck.Cards = new List<Card>();
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();








            //Card cardone = new Card();
            //cardone.face = "queens";
            //cardone.suit = "spades";

            //Console.WriteLine(cardone.Face + " of " + cardone.Suit);
            //Console.ReadLine();

        }
    }
}
