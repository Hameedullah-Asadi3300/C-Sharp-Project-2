using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffling(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffling(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
        }
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

