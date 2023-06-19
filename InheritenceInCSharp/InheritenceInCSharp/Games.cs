using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceInCSharp
{
    internal class Games
    {

        public class Game
        {
            public List<string> players { get; set; }
            public string Name { get; set; }
            public string Dealer { get; set; }
            
            //This method prints list of the players to the console
            public void ListPlayers()
            {
                foreach (string player in players)
                    {
                    Console.WriteLine(players);
                    }
            }
        }






    }
}
