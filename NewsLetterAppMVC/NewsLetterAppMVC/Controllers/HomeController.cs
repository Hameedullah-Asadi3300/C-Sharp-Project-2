using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //  Here we need to connect our database created on SSMS so the information is recorded in.
        //  This is our connection string which connects the database with the form.
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        private object sqlDbType;
        private SqlConnection connection;

        public int NewsLetterSignUp { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        //  This is the method created for SignUp form which is also known as controller
        [HttpPost]  //  It is good practice to write [HttpPost] whenever we post something, however that is not necessary
        public ActionResult SignUp(string FirstName, string LastName, string Email)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email))   //This if statement checks if any of these values were empty, then return the error which is in Views/Shared/Error.cshtml
            {
                return View("~/Views/Shared/Error.cshtml"); //  This is the path for that error page
            }
            else    //  Otherwise success view will be diaplayed/returned. We also created a view under "Success" name
            {       //  This is also called server validation.    
                
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, Email) VALUES
                                    (@FirstName, @LastName, @Email)";



                using (SqlConnection connection = new SqlConnection(connectionString))   //  Here is a bug should be made correct - PART 7 OF MVC APPLICATION
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@Email", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = FirstName;
                    command.Parameters["@LastName"].Value = LastName;
                    command.Parameters["@Email"].Value = Email;

                    connection.Open();
                        command.ExecuteNonQuery();
                    connection.Close();

                }
                return View("Success");
            }
        }

        public NewsletterSignUp GetNewsletterSignUp()
        {
            return NewsletterSignUp;
        }

        public SignupVM GetSignupVM()
        {
            return SignupVM;
        }



        //  This method is used to get the signups by administrator
        public ActionResult Admin(NewsletterSignUp newsletterSignUp, SignupVM signupVM)
        {
            string queryString = @"Select id, FirstName, LastName, Email, SocialInsuranceNumber from SignUp";

            List<NewsLetterSignUp> signups = new List<NewsLetterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var signUp = new NewsletterSignUp();
                    signUp.id = Convert.ToInt32(reader["id"]);
                    signUp.FirstName = reader["FirstName"].ToString();
                    signUp.LastName = reader["LastName"].ToString();
                    signUp.Email = reader["Email"].ToString();
                    signUp.SocialInsuranceNumber = reader["SocialInsuranceNumber"].ToString();

                    signups.Add(signUp);

                    //Here we want to prevent the SIN from displaying to the admin for security and safety reasons
                }
            }
            //  By using view models in this project we have limited the information/field passing to the view
            var signupsVms = = new List<SignupVM>();
            foreach (var signup in signups)
            {
                var SignupVM = new SignupVM();
                signupVM.FirstName = signup.FirstName;      //  Need to be debugged
                signupVM.LastName = signup.LastName;        //  Need to be debugged
                signupVM.Email = signup.Email;              //  Need to be debugged
                signupsVms.Add(signupVM);   
            }
                return View(signupsVms);
        }
    }
    internal class NewsLetterSignUp
    {
    }
}