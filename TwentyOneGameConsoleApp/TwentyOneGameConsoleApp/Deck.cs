using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameConsoleApp
{
    public class Deck //Deck is collection of cards
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Face = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "jack", "Queen", "King", "Ace"
            };
            foreach (string face in Face)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);

                }
            }
        }



    public List<Card> Cards { get; set; }
    }
}

                        //    Cards = new List<Card>();
                        //    Card cardOne = new Card();
                        //    cardOne.Face = "Two";
                        //    cardOne.Suit = "Hearts";
                        //    Cards.Add(cardOne);


   
