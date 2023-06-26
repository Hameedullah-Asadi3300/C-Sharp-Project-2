using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //  In order to use login we use System.IO namespace becuase the file text exists here.

namespace TwentyOneGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthYear = new DateTime(1995, 05, 27, 08, 48, 13); //  The DateTime object has six parameters of year, month, day, hours, minutes, and seconds
            //Second DateTime object for timespan

            DateTime yearOfGraduation = new DateTime(2015, 12, 22, 2, 29, 45);
            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            ageAtGraduation.Duration();
            //  The timespan object has a lot of built-in features which do different math operations
            //  The most useful usage of DateTime object is in logging where all logs are appeared with exact time.


            //  The text file/Login created
            string text = "Here is some text";  
            File.WriteAllText(@"C:\Users\Hameed\Logs\log.txt", text);   //   The "@" means ingnore the space otherwise we need to give back slash "\\" instead one like so: C:\\Users\\Hameed\\Logs\\log.txt, text
            //  Logging statements ended


            Console.WriteLine("Welcome to the grand Hotel and Casino. Let's start with telling your name:");
            string playerName = (Console.ReadLine());
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            //  The player name will be placed inside {0}. Loved this feature!

            Console.WriteLine("Hello, {0}, Would you join the game of twenty one?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "Yes" || answer == "YES" || answer == "yeah" || answer == "y" || answer == "yup")
            {
                Player player = new Player(playerName, bank);    // Referenced from "player" class
                Game game = new TwentyOneGame(player);
                game += player;     //  This statement adds player to the game if they said yes to join the game
                player.isActivePlaying = true;
                //  We are creating while loop which says to program that play the game while and until the playr wants to actively play under certain condition
                while (player.isActivePlaying && player.Balance > 0) // 2 conditions are set. 1st as long as the player wants and 2nd as the player has balance over 0               
                {
                    game.Play();
                }
                game -= player;     //  If the player decides to exits from game, this code will subtract him and displays the following message
                Console.WriteLine("Thanks for playing1");       
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}



