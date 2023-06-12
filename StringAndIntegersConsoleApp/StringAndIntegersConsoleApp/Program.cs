using System;
using System.Collections.Generic;



    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = new List<int> { 20, 40, 65, 90, 110, 135, 145, 180, 200 }; //List of integers
            bool numValid = false;
            while (numValid == false)
            {
                try
                {
                    Console.WriteLine("\nPick a number to divide above list by:");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)  //MAkes sure that the user should not enter 0
                    {
                        Console.WriteLine("Please pick a number other than 0");
                    }
                    else
                    {
                        foreach (int num in num1)
                        {
                            float divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + divide);
                        }
                        numValid = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("The program exited the try/catch block.");
                Console.ReadLine();
            }
        }
    }
