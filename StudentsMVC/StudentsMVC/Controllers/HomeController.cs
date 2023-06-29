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

        public ActionResult Instructors(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Instructors()
        {
            return View();
        }


    }
}