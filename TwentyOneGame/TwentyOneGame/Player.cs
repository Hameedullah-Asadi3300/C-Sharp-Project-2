using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        //This is constructor for "Player" class which takes two parameters which assigns some values
        public Player(string name, int BegenningBalance)
        {
            Hand = new List<Card>();
            Balance = BegenningBalance;
            Name = name;
        }


        private List<Card> _hand = new List<Card>();
     

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string name { get; set; }
        public bool isActivePlaying { get; set; }
        public bool stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;

        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.remove(player);
                return game;
        }







    }
}
