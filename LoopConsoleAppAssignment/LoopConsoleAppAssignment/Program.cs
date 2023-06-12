using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;

namespace LoopConsoleAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            string[] wordStart =
            {
                "Welcome to the ",
                "I am the chacelor, ",
                "Our goal is to provide students with a/an ",
            };
            string[] wordEnd =
            {
                "BCIT.",
                ".",
                " learning experience.",
            };
            List<string> responses = new List<string>();
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter name of someone famous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjectve: ");
            responses.Add(Console.ReadLine());
            for (int i = 0; i < wordStart.Length; i++)
            {
                wordStart[i] += responses[i];
            }
            Console.ReadLine();
            Console.WriteLine("The string we used: ");
            for (int i = 0; i < wordEnd.Length; i++)
            {
                Console.WriteLine(wordStart[i] + wordEnd[i]);
            }


            //Part 3
            Console.WriteLine("Is that a ghost?");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");

            while (ahh.Length < 10)
            {
                ahh.Append("A");
            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();


            //Part 4
            List<string> teams = new List<string>() { "Bucks", "Raports", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
            "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };
            Console.WriteLine("NBA Eastern Conference Standings");
            //Ask the user to input text to search for in the list.
            Console.WriteLine("Enter team name: ");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            while (!isValid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //Add code to that above loop that tells a user if the put in text that is not in the list.
                if (standing == 0)
                {
                    Console.WriteLine("That is not a valid team name. Enter again:");
                }
                //Add code to that above loop that stop if from executing once a match has been found.
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Processing... index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing);
            Console.ReadLine();




            //Part 5
            //Create a list of string that has at least two identical strings in the list.
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to Swell Taco! \nDue to COVID-19 we have computerized check-in. \nif you have a reservation type " +
                "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\".\nOtherwire type \"Vacant\".");
            //Ask the user to select text to search for in the list.
            Console.WriteLine("Enter selection:");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //Add code that tells the user if the put in th text that is not in the list.
                Console.WriteLine("Please enter one of the 4 choices:");
                //Create a loop that iiterates through the loop and then displats the indicates of the array that contain matching text on the screen.
                for (int i3 = 0; i3 < tables.Count; i3++)
                {
                    if (selection == tables[i3])
                    {
                        Console.WriteLine(i3);
                    }
                }
                Console.ReadLine();


                //Part 6
                //Create a list of strings that has at east two identical strings in the list.
                List<string> names = new List<string>() { "Bon", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
                List<string> repeatCheck = new List<string>();
                Console.WriteLine("Calss Roster:");
                //Creeatte a foreach loop that evaluates each item in the lost, and displays a message showing string and whether or not it has already appeared in the list.
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                    if (repeatCheck.Contains(name))
                    {
                        Console.WriteLine("This name has been repeated. \nUse last name initial when refering to this student.");
                    }
                    else
                    {
                        Console.WriteLine("This name has not been repeated.");
                    }
                    repeatCheck.Add(name);
                }
                Console.ReadLine();
            }
        }
    }
}

        



