using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Game
    {
        private List<Player> _Players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();



        public List<Player> Players { get { return _Players; } set { _Players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }


        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.name);
            }
        }
    }
}
