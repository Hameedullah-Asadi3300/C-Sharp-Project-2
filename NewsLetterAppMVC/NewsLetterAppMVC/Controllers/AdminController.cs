using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var signups = db.SignUps;
                var signupsVms = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVM();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.Email = signup.Email;
                    signupsVms.Add(signupVm);
                }
                return View(signupsVms);
            }
        }
    }
}