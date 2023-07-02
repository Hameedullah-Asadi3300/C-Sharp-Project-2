using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //This is lambda syntax
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();  //  Here we grab all signup from database and the code after .Where filterize the list to only those who has not unsubsribed
                //  We can also use the following LINQ statement as an alternative to the above statement
                /*
                var Signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                */
                       
                var signupsVms = new List<SignupVM>();      //  We created a list of view models
                foreach (var signup in signups)             
                {
                    //  We are looping through the models
                    var signupVm = new SignupVM();
                    //  And mapped to the view model
                    signupVm.id = signup.id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.Email = signup.Email;
                    signupsVms.Add(signupVm);
                }
                return View(signupsVms);
            }
        }

        //  This is method is to add functionality or logic the subscribe button in index.cshtml
        //  What happens in this method?
        //  We hit the button, it gets the ID, it finds the record matches that ID, changes the removed column to DateTime.Now and it saves that
        public ActionResult Unsubscribe(int id)
        {
            using (NewsletterEntities db = new NewsletterEntities())    //  This using statement automatically connect the method to the database
            {
                var signup = db.SignUps.Find(id);   //  By using the primary key of our table in database, we are actually able to find that Email is being unsubsribed
                signup.Removed = DateTime.Now;  //  This statement is acullay recording the date time of the email which in usubscribed
                db.SaveChanges();   //  And this statement save changes into database
            }
            return RedirectToAction("Index");
        }
    }
}