using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {
        public string Name { get; set; }
        public Deck deck { get; set; }
        public int Balance { get; set; }


        public void Deal (List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
        }
    }
}
