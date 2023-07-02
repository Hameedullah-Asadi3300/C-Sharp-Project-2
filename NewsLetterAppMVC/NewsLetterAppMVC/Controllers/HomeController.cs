using Microsoft.Ajax.Utilities;
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
        public ActionResult Index()
        {
            return View();
        }

        //  This is the method created for SignUp form which is also known as controller
        [HttpPost]  //  It is good practice to write [HttpPost] whenever we post something, however that is not necessary
        public ActionResult SignUp(string firstName, string lastName, string email)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))   //This if statement checks if any of these values were empty, then return the error which is in Views/Shared/Error.cshtml
            {
                return View("~/Views/Shared/Error.cshtml"); //  This is the path for that error page
            }
            else    //  Otherwise success view will be diaplayed/returned. We also created a view under "Success" name
            {       //  This is also called server validation.    
                //  We are instantiated our object abd named it db
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    //  These are the properties we have mapped to the object and the parameters cane in
                    var signup = new SignUp();
                    signup.FirstName = firstName;   //  firstName is the parameter
                    signup.LastName = lastName;     //  lastName is the parameter
                    signup.Email = email;           //  email is the parameter

                    //  Now we have this object and we want to add it to our database
                    db.SignUps.Add(signup);
                    db.SaveChanges();   // Throws an error
                }
                return View("Success");
            }
        }
                   
    }
}



//public ActionResult Admin()
//{
//using (NewsletterEntities db = new NewsletterEntities()) //  Here we instantiated the "NewsletterEntities" object that gives us access to the database
//{
//  Now we are using the db object to access the database

//var signups = db.SignUps;     //    We created a variable called signups and it is equal to db.SignUps which represents all of the records in that database  
//var signupsVms = new List<SignupVM>();  //  We created a new list of view models 
//foreach (var signup in signups)         //We mapped the view models from model to the view model 
//{
//var SignupVM = new SignupVM();
//signupVM.FirstName = signup.FirstName;      //  Need to be debugged
//signupVM.LastName = signup.LastName;        //  Need to be debugged
//signupVM.Email = signup.Email;              //  Need to be debugged
//signupsVms.Add(signupVM);
//}
//return View(signupsVms);    //  We paased the list to the view
//}
//}

//      WE ARE REPLACING THE FOLLOWING COMMENTS WITH THE ENTITY FRAMEWORK SYNTAX AS ABOVE. BOTH ARE ALTERNATIVES TO EACH OTHERS AND BOTH WORK THE SAME WAY
//string queryString = @"Select id, FirstName, LastName, Email, SocialInsuranceNumber from SignUp";
//List<NewsLetterSignUp> signups = new List<NewsLetterSignUp>();
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    connection.Open();
//    SqlDataReader reader = command.ExecuteReader();
//    while (reader.Read())
//    {
//        var signUp = new NewsletterSignUp();
//        signUp.id = Convert.ToInt32(reader["id"]);
//        signUp.FirstName = reader["FirstName"].ToString();
//        signUp.LastName = reader["LastName"].ToString();
//        signUp.Email = reader["Email"].ToString();
//        signUp.SocialInsuranceNumber = reader["SocialInsuranceNumber"].ToString();
//        signups.Add(signUp);

//Here we want to prevent the SIN from displaying to the admin for security and safety reasons
//    }
//}
//  By using view models in this project we have limited the information/field passing to the view




