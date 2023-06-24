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
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<player, int> Bets { get; set; }


        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
