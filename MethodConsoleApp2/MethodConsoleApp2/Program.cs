using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MethodOperation mathOp = new MethodOperation();
            {
                Console.WriteLine("Please pick a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please pick a second number:");
                try
                {
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result = mathOp.MathOperations(num1, num2);
                    Console.WriteLine(num1 + " x " + num2 + " = " + result);
                }
                catch
                {
                    int result = mathOp.MathOperations(num1);
                    Console.WriteLine(num1 + " x defualt 1 + = " + result);
                }
                Console.ReadLine();
            }

        }
    }
}
