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

        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string name { get; set; }
        public bool isActivePlaying { get; set; }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;

        }









    }
}
