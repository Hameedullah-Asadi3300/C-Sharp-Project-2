using System;
using System.Collections.Generic;


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
            //String iteration
            string[] fNames = { "Nabi", "Ahmed", "Mohammed", " Shuhab" };
            for (int j = 0; j < fNames.Length; j++)
            {
                Console.WriteLine("fNames"[j]);
                Console.ReadLine();
            }
        }




    }
}
