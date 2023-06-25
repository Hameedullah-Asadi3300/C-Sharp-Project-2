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
            Dealer.Deck.Shuffle();
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
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}," player.name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses");
                        foreach (KeyValuePair<player, int> entry  in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "Stay")
                    {
                        player.stay = true;
                        break;
                    }
                    else if (answer == "hit") ;
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose  your bet of {1}. Your balance is now {2}.", player.name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "Yes" || answer == "yes" || answer == "ya")
                        {
                            player.isActivePlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivePlaying = false;
                            return;
                        }
                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.stay = TwentyOneRules.ShouldDealerStay[Dealer.Hand];
            while (!Dealer.stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted");
                /*We are looping through each key value pair and we are finding the player in players list that matches that key value pair where the name where are dealing here
                */
                foreach (keyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);      //Lambda expression
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }

            foreach (Player player in Players)
            {
                //  with this "?", now this value is nullable
                bool? playwerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "Yes" || answer == "Yah" || answer == "Yeah")
                {
                    player.isActivePlaying = true;
                }
                else
                {
                    player.isActivePlaying = false;
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
