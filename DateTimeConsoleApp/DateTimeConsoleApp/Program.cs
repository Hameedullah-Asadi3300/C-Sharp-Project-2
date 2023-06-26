using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  This statement prints the current time.
            Console.WriteLine("It is: " + DateTime.Now);
            Console.WriteLine("\nPlease enter a random number");    //  Ask the user to write a number.
            float response = float.Parse(Console.ReadLine());   //  Converts the answer to float data type.
            //  prints the exact current time, then the user`s int input and turns that output to the number of hours and the next exact time based on the user's input
            Console.WriteLine("{0} + {1} hour(s) + {2}", DateTime.Now, response, DateTime.Now.AddHours(response));


            Console.ReadLine();
        }
    }
}
