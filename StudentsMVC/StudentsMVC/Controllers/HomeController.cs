using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //  The return type of this method is ActionResult and it has no parameter
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page for Academy of Learning Career College";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            // Instantiated an object for Instructor
            Instructor DayTimeInstructor = new Instructor
            {
                Id = 100,
                FirstName = "Hameedullah",
                LastName = "Asadi"
            };
            return View(DayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            //  We are creating a list for Instructor
            List<Instructor> Instructor = new List<Instructor>();
            new Instructor
            {
                Id = 100,
                FirstName = "Hameedullah",
                LastName = "Asadi"
            };
            new Instructor
            {
                Id = 101,
                FirstName = "Joe",
                LastName = "Smith"
            };
            new Instructor
            {
                Id = 102,
                FirstName = "Michael",
                LastName = "Frank"
            };
            return View(Instructor);
        }
    }
}