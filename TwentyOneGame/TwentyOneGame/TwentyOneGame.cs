using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)   //  Means if successfullBet false then print the next statement which says end the method
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing ...");
                foreach (Player player in Player)
                {
                    Console.WriteLine("{0}" player.name)    //  This method which does not have "Line" means it prints the statement but not on new line 
                    Dealer.Deal(player.Hand);
                }
            }


            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
