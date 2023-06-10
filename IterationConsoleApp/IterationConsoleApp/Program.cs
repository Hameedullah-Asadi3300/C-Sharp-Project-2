using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;

namespace IterationConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int array iteration
            int[] testScroes = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            for (int i = 0; i < testScroes.Length; i++)
            {
                if (testScroes[i] > 85)
                {
                    Console.WriteLine("passing test score " + testScroes[i]);
                    Console.ReadLine();
                }
            }


            //int array iteration 2
            int[] scores = { 100, 200, 300, 400, 500, 600 };
            for (int d = 0; d < scores.Length; d++)
            {
                if (scores [d] > 200)
                {
                    Console.WriteLine("Passing test is " + scores[d]);
                    Console.ReadLine();
                }
            }


            //int array iteration 3
            int[] homeAdress = { 2345, 2789, 2567, 4589, 9832, 5690, 1243 };
            for (int h = 0; h <homeAdress.Length; h++)
            {
                if (homeAdress[h] > 2789)
                {
                    Console.WriteLine("Your home address is " + homeAdress[h]);
                    Console.ReadLine();
                }
            }


            //String iteration 1
            string[] fNames = { "Nabi", "Ahmed", "Mohammed", "Shuhab" };
            for (int j = 0; j < fNames.Length; j++)
            {
                Console.WriteLine(fNames[j]);
                Console.ReadLine();
            }


            //String iteration 2
            string[] lName = { "Asadi", "Ghafari", "Hashimi", "Qasemi" };
            for (int g = 0; g <lName.Length; g++)
            {
                Console.WriteLine(lName[g]);
                Console.ReadLine();
            }


            //String array iteration 3
            string[] cities = { "I love Vancouver.", "I love Calgary.", "Toronto", "Halifax" };
            for (int c = 0; c < cities.Length; c++)
            {
                Console.WriteLine(cities[c]);
                Console.ReadLine();
            }


            string[] computers = { "Dell", "HP", "acer", "Mac", "Evolve" };
            for (int y = 0; y < computers.Length; y++)
            {
                Console.WriteLine("I like " + computers[y]);
                Console.ReadLine();
            }


            //List iteration on string data type
            List<string> names = new List<string>();
            names.Add("Ben");
            names.Add("Ahmed");
            names.Add("Manizha");
            names.Add("Safiullah");
            names.Add("Suliaman");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            //List iteration on string data type
            List<int> numbers = new List<int>() { 150, 250, 350, 450, 550, 650, 750, 850, 950, 1050 };
            foreach (int number in numbers)
            {
                if (number > 550)
                    {
                    Console.WriteLine("The number " + number);
                    Console.ReadLine();
                }
            }
            Console.ReadLine();


            //List iteration int dta type
            List<int> num3 = new List<int>() { 110, 210, 310, 410, 510, 610, 710, 810, 910, 1010 };
            foreach (int num in num3)
            {
                if (num > 310)
                {
                    Console.WriteLine("The number is " + num);

                Console.ReadLine();
                }
            }
            Console.ReadLine();



            //Note: We can iterate a list, and while a condition is met, we can also add the value to another list
            List<int> newScore = new List<int>() { 74, 92, 83, 98, 91, 85, 65 };  //This is the list with values specified
            List<int> passingScores = new List<int>(); //This is an empty value to which we want to add the values
            foreach (int score in newScore) 
            {
                if (score >= 85)  //This is the condition says the value above or equal to 85
                {
                    passingScores.Add(score);    //This adds the over 85 value to the empty list called passingScores
                }
            }
            Console.WriteLine(passingScores.Count);  //It counts the added value to the empty list
            Console.ReadLine();  //This keeps the console open




            //Passing the value to another empty list and counting the pased value
            List<int> phoneLineNumber = new List<int>();
            List<int> passingPhuneNumber = new List<int>();
            phoneLineNumber.Add(236);
            phoneLineNumber.Add(604);
            phoneLineNumber.Add(782);
            phoneLineNumber.Add(445);
            phoneLineNumber.Add(554);
            phoneLineNumber.Add(436);
            phoneLineNumber.Add(376);
            foreach (int phone in phoneLineNumber)
            {
                if (phone >= 445)
                {
                    passingPhuneNumber.Add(phone);
                }
            }
            Console.WriteLine(passingPhuneNumber.Count);
            Console.ReadLine();


            //Passing the value to another empty list and counting the pased value
            List<string> countries = new List<string>() { "Sweden", "Denmark", "Australia", "Finland" };
            List<string> passingCountries = new List<string>();
            foreach (string country in countries)
            {
                if (country == "Sweden")
                {
                    passingCountries.Add(country);
                }
            }
            Console.WriteLine(passingCountries.Count);
            Console.ReadLine();









        }

    }
}
