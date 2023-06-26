using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //  In order to use login we use System.IO namespace becuase the file text exists here.
using System.Diagnostics.Eventing.Reader;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOneGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthYear = new DateTime(1995, 05, 27, 08, 48, 13); //  The DateTime object has six parameters of year, month, day, hours, minutes, and seconds
            //  Second DateTime object for timespan

            DateTime yearOfGraduation = new DateTime(2015, 12, 22, 2, 29, 45);
            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            ageAtGraduation.Duration();
            //  The timespan object has a lot of built-in features which do different math operations
            //  The most useful usage of DateTime object is in logging where all logs are appeared with exact time.


            //  The text file/Login created
            string text = "Here is some text";  
            File.WriteAllText(@"C:\Users\Hameed\Logs\log.txt", text);   //   The "@" means ingnore the space otherwise we need to give back slash "\\" instead one like so: C:\\Users\\Hameed\\Logs\\log.txt, text
            //  Logging statements ended


            Console.WriteLine("Welcome to the grand Hotel and Casino. Let's start with telling your name:");
            string playerName = (Console.ReadLine());

            // Lets create a command that will print out a log of exception
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadOnlyException();
                foreach (var exception in Exceptions)
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }


            //  EXCEPTION HANDLING
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals!");   //  This is another exception handling which says if the answer is still wrong, ask the user to enter digits only
            }
            //EXCEPTION HANDLING ENDS


            int bank = Convert.ToInt32(Console.ReadLine());
            //  The player name will be placed inside {0}. Loved this feature!

            Console.WriteLine("Hello, {0}, Would you join the game of twenty one?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "Yes" || answer == "YES" || answer == "yeah" || answer == "y" || answer == "yup")
            {
                Player player = new Player(playerName, bank);    // Referenced from "player" class
                Game game = new TwentyOneGame(player);
                game += player;     //  This statement adds player to the game if they said yes to join the game
                player.isActivePlaying = true;
                //  We are creating while loop which says to program that play the game while and until the playr wants to actively play under certain condition
                while (player.isActivePlaying && player.Balance > 0) // 2 conditions are set. 1st as long as the player wants and 2nd as the player has balance over 0               
                {
                    //EXCEPTION HANDLING STARTS
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        updateDbWithException(ex);  //  Connected to the database we created
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured, please contact your system administrator.");
                        updateDbWithException(ex);  //  Connected to the database we created
                        Console.ReadLine();
                        return;
                    }
                    //EXCEPTION HANDLING ENDS
                    game.Play();
                }
                game -= player;     //  If the player decides to exits from game, this code will subtract him and displays the following message
                Console.WriteLine("Thanks for playing1");       
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        //  This is method is special to catch the exceptions and log into database
        private static void updateDbWithException(Exception ex)
        {
            //  This connection string contains about the dtatabse instance we are trying to connect to like; username, password, where it is, how to access it and ...
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = 
                                        True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent
                                          = ReadWrite; Multi Subnet Failover = False";

            //  Query string
            string queryString = "INSERT INTO Exceptions (ExcpetionType, ExceptionMessage, TimeSpan) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //  using is a way of controlling unmanaged code or unmanaged resources
            using (SqlConnection connection = new SqlConnection(connectionString)) //Once we exit the last {} it aumotically shuts down and makes the space in memory.
            {                
                SqlCommand command = new SqlCommand (queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@Timestamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@Timetamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //  Lets create our readexception method. This method calls the database and get back all the exceptions and display them
        private static List<ExceptionEntity> ReadException()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = 
                                        True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent
                                          = ReadWrite; Multi Subnet Failover = False";

            string queryString = @"select Id, ExceptionType, ExceptionMessage, TimeStmap From Exceptions";

            List<ExceptionEntity> Exception = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlConnection command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exception.Add(exception);
                }
                connection.Close();

            }
            return Exceptions();
        }
    }
}



