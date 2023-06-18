using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anum1 = 200;                    //Stored a value of 200 inside variable anum1
            int anum2 = 400;                    //stored a value of 400 inside variable anum2
            SecondMethod(anum1, anum2);         //Instintiated the method named SecondMethod
            Console.ReadLine();                 //Keeps the console open


            int num3 = 400;
            int num4 = 500;
            Console.WriteLine("Pick a number to add it by 400");
            int response = Convert.ToInt32(Console.ReadLine());
            int result = 100;
            FourthMethod(num3, num4);
            Console.ReadLine();
           



        }

        static void SecondMethod(int anum1, int anum2)      //Created a void method named SecondMEthod with two parameters
        {
            Console.WriteLine("The value of first integer is " + anum1 + ".");          //Concatenates and displays the value
            anum2++;                                                                    //Increments the 400 by 1
            Console.WriteLine("The value of second incremented integer is " + anum2 + "."); //Concetenates and displays the value of anum2
            Console.ReadLine(); //Keeps the console open
        }

        static void FourthMethod(int num3, int num4)
        {
            Console.WriteLine(num3 * num4);
            Console.WriteLine("The result is " + " ");
        }

    }
}
