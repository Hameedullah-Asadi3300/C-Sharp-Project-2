using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //  The log statement inside this method keeps log of ths method in a seperate text file
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");  //  Here the Deck/Cards.First().ToString() is logged
            Console.WriteLine(card);
            //The following statement cleans up the memory after it get done the job
            using (StreamWriter file = new StreamWriter(@"C:\Users\Hameed\Logs\\log.txt", true))
            {
                file.WriteLine(DateTime.Now);   //  By using DateTime object in this method, the logs are filed with the current time. It makes sure when something happens.
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);




        }
    }
}
