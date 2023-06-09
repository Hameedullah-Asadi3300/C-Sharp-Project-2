using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            //String Data type array,  method 1
            string[] cities = new string[10];  //10 is 0 based index length, and we can not insert more than 10 values in this array
            cities[0] = "Vancouver";
            cities[1] = "Toronto";
            cities[2] = "Halifax";
            cities[3] = "Victoria";
            cities[4] = "Frankfort";
            cities[5] = "Hamborg";
            cities[6] = "Berlin";
            cities[7] = "Munchen";
            cities[8] = "Kelowna";
            cities[9] = "Montreal";
            Console.WriteLine(cities[6]); //Prints the index 6 value
            Console.ReadLine();

            //string data type array, method 2
            string[] cities2 = new string[] { "Berlin", "Ottawa", "Quebec", "Victoria" }; //We did not specify the lenght, so we can insert as many inputs as we want
            Console.WriteLine(cities2[2]); //Prints the index 2 value
            Console.ReadLine();

            //String data type array, method 3
            string[] cities3 = { "Berlin", "Ottawa", "Quebec", "Victoria" };
            Console.WriteLine(cities3[2]);
            Console.ReadLine();

            /*--------------------*/

            //String data type,  method 1
            string[] countries = new string[5]; //The lenght is 5 here
            countries[0] = "Germany";
            countries[1] = "Sweden";
            countries[2] = "Japan";
            countries[3] = "South Korea";
            countries[4] = "United States";
            Console.WriteLine(countries[3]); //Prints the index 3 value
            Console.ReadLine();

            //String data type,  method 2
            string[] countries2 = new string[] { "Germany", "sweden", "Japan", "South Korea", "United Sttes" };
            Console.WriteLine(countries2[4]); //Prints the index 4 value
            Console.Read();

            //String data type array method 3
            string[] countries3 = { "Germany", "sweden", "Japan", "South Korea", "United Sttes" };
            Console.WriteLine(countries3[4]); //prints the index 4 value
            Console.Read();

            /*--------------------*/

            //Int data type array, method 1
            int[] numArray = new int[5];
            numArray[0] = 100;
            numArray[1] = 200;
            numArray[2] = 300;
            numArray[3] = 400;
            numArray[4] = 500;
            Console.WriteLine(numArray[3]); //Prints the index 3 value
            Console.Read();

            //Int data tyoe array,  method 2
            int[] numArray2 = new int[] { 00, 700, 800, 900, 1000 }; //This syntax is more clean and short
            Console.WriteLine(numArray2[3]); //Prints the index 3 value
            Console.Read();

            //Int data type array, method 3
            int[] numArray3 = { 600, 700, 800, 900, 1000 };
            Console.WriteLine(numArray3[2]);
            Console.ReadLine();

            /*--------------------*/

            //We can also change the targeted value as follows
            int[] numArray4 = { 150, 250, 350, 450, 550, 650 };
            numArray4[4] = 600;  //This changes the index 4 from 550 to 600
            Console.WriteLine(numArray4[4]); //Prints the value of index 4
            Console.Read();

            //Changing the string data type value in array
            string[] names = { "Hameed", "Safi", "Sulaiman", "Nabil", "Hisham" };
            names[2] = "Emran";
            Console.WriteLine(names[2]);
            Console.ReadLine();

            //Note:Array is mostly used for fixed values that we are they will never change
            /*--------------------*/

            /*We can create list with any data type in c#*/
            List<int> intList = new List<int>();
            intList.Add(120);
            intList.Add(220);
            intList.Add(320);
            intList.Add(420);
            intList.Add(520);
            intList.Add(620);
            intList.Add(720);
            Console.WriteLine(intList[4]);
            Console.ReadLine();

            //string data type list
            List<string> StrCountries = new List<string>();
            StrCountries.Add("China");
            StrCountries.Add("Japan");
            StrCountries.Add("\"Finland\"");
            StrCountries.Add("Italy");
            StrCountries.Add("France");
            Console.WriteLine(StrCountries[2]);
            Console.Read();
        }
    }
}
