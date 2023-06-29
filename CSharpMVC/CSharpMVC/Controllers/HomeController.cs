using CSharpMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CSharpMVC.Controllers
{
    public class HomeController : Controller
    {

        //  This is the first controller method controls everything about "Index" web page
        public ActionResult Index()
        {

            //  Instantiated an object of Model named User
            User user = new User();
            user.Id = 1;
            user.FirstName = "Hameedulah";
            user.LastNAme = "Asadi";
            user.age = 27;
            //  End

           
            //  this is a list that we want to to pass it to view
            string text = "Hello";   //  So every time someone visits this file Home/Index, the word "Hello" will be written/added to the log file.
            System.IO.File.WriteAllText(@"D:\GIT\C-Sharp-Project-2\CSharpMVC\log.txt", text); //    This is the path n which the log.txt has been created


            //  Generating a random number of 10 digits
            Random random = new Random(10);
            var num = random.Next();
            ViewBag.randomNumber = num;
            return View();
        }

        //  This is another controller the method controls everything about "About" P webage"
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //  The following code throws a "Invalid" page error when womeone clicks the About page.
            throw new Exception("Invalid Page");

            return View();
        }


        //  This is another controller method which controls everything about "Contact" web page
        public ActionResult Contact(int id = 0)   //  Here we can also write down a parameter inside the Parenthesis
        {
            ViewBag.Message = id;

            return View();
        }
    }
}