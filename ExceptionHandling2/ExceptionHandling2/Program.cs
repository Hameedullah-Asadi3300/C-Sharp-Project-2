using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try   //    Starting point of try/catch block
            { 
            Console.WriteLine("How old are you?"); //   Asks user
            int answer = Convert.ToInt32(Console.ReadLine());   //  Converts the user's input to int32
                if (answer == 0)    //  Checks if the user enters wrong number
                {
                    Console.WriteLine("Please enter the correct age as number!");   //  If under 0, the message is displayed
                    Console.ReadLine();     //  Keeps the console open
                    return; //  return the method
                }
                else if (answer < 18)   //  Second cndition which says if the age is less than 18
                {
                    Console.WriteLine("You are not allowed to vote in election.");  //  Then displays this message
                    Console.ReadLine(); //  Keeps the console open
                    return; //  return the method
                }           
            Console.WriteLine(DateTime.Now.Year - (answer) + " is the year you were born.");    //  Subtracts the age from current year and displays the year that the user was  born
            Console.ReadLine(); //Keeps the console open

            }
            catch (Exception ex)    //  This is the catch block which displays general message
            {
                Console.WriteLine(ex.Message);  //  The message
            }
        }
    }
}
