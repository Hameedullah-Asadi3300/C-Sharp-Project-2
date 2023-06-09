using System;
using System.Collections.Generic;


namespace FavoriteCountriesConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            string[] favoriteCountry = { "Australia", "Turkey", "Norway", "Scotland", "Japan", "Denmark", "Qatar", "Italy", "France", "Singapore" };
            Console.WriteLine("Hi Friend, \n");
            Console.WriteLine("choose Your favorite number from 0-9 to match your favorite country.");
            int sringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite country is " + favoriteCountry[sringSelect] + ".");
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("This number is invalid. please choose a number from 0-9.");
                    sringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();


            //Scond game - This programs asks the user for int input to match their lucky number
            int[] luckyNumber = { 20, 40, 60, 80, 120, 160, 220, 320, 530 };

            Console.WriteLine("Choose another number from 0-9.");
            int selectNumber = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;
            while (validInt == false)
            {
                try
                {
                    Console.WriteLine("your lucky number is " + luckyNumber[selectNumber] + ".");
                    validInt = true;
                }
                catch
                {
                    Console.WriteLine("You did not choose invalid number. Please choose a number from 0-9.");
                    selectNumber = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Third game - This program asks the user for int input to match their next destinaton
            List<string> nextDestination = new List<string>()
            {
            "Tokyo",
            "Madrid",
            "Ottawa",
            "Sydney",
            "Toronto",
            "Paris",
            "Milan",
            "Berlin",
            "Halifax",
            "Califronia"

            };
            Console.WriteLine("Choose another number from 0-9");
            int choosetNumber = Convert.ToInt32(Console.ReadLine());
            bool validList = false;
            while (validList == false)
            {
                try
                {
                    Console.WriteLine("Your next destination will be " + nextDestination[choosetNumber] + ".");
                    validList = true;
                }
                catch
                {
                    Console.WriteLine("Your choose number is not valid. Please choose a number from 0-9.");
                    choosetNumber = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Thanks for your participation. Have a good day!");
            Console.ReadLine();
        }
    }
}
