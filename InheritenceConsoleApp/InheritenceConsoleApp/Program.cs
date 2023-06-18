using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Dealer = "Jesse";
            game.Players = new list<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayer();
            Console.ReadLine();
            game.play();    //This is the statement that calls the "play" method in "TwentyOneGame", but it is not implemented








            //Game game = new Game();
            //game.Dealer = "Jesse";
            //game.Name = "Jesse";



        }
    }
}
