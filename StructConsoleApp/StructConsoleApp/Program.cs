using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number1; //An object of struct Number created
            {
                number1.Amount = 500;   //The value for Number is $50..
                Console.WriteLine("The total amount to be paid is " + "$" + number1.Amount + ".");
                Console.ReadLine();
            }
        }
        //A struct named "Number" declared
        public struct Number
        {
            public decimal Amount;      //This struct has one property of Amount

        }
    }
}
