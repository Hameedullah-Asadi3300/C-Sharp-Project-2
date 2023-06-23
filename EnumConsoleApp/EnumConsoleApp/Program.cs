using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnumConsoleApp.Days;

namespace EnumConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            while (isValid) 
            {
            try
                {
                    //Asks user to enter current day of the week
                    Console.WriteLine("Enter current of the week.");
                    string dayInput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you just created.
                    WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), dayInput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isValid = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                    Console.ReadLine();
                }
            }

        }
    }
}
