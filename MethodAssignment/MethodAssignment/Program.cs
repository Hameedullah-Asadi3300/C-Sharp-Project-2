using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondMethod(int anum1);                    //Instantiating the method
            SecondMethod(int anum2);                    //Instantiting the method
            Console.ReadLine();                     //Keeps the console open
        }

        static void SecondMethod(int anum1, int anum2)  //Created a void method with two integer data type
        {
            int num1 = 300; //First value of integer data type
            Console.WriteLine("The value of first integer is " + num1 + " ."); //Conactaenates and display the value of num1
            int num2 = 500; //Second value of integer data type
            num2++;         //MAth operation that increments the value of "num2" int data type
        }

    }
}
