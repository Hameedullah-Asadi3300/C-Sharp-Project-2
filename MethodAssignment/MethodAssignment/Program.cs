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
            int anum1 = 200;                    //Stored a value of 200 inside variable anum1
            int anum2 = 400;                    //stored a value of 400 inside variable anum2
            SecondMethod(anum1, anum2);         //Instintiated the method named SecondMethod
            Console.ReadLine();                   
        }

        static void SecondMethod(int anum1, int anum2) 
        {
            anum1 = 200;
            Console.WriteLine("The value of first integer is " + anum1 + ".");
            anum2 = 400;
            anum2++;
            Console.WriteLine("The value of second incremented integer is " + anum2 + ".");
            Console.ReadLine();
        }
    }
}
