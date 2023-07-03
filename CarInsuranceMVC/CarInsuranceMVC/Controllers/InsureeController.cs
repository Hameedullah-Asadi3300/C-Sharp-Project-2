using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using CarInsuranceMVC.Models;

namespace CarInsuranceMVC.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }




        //  Adding logic to the code
        public ActionResult Quote(Insuree insuree)
        {
            decimal Quote = 50m;                                               //  This is the base payment
            int age = DateTime.Now
                      - insuree.DateofBirth.Year;           //  Customer's age calculation
            if (age <= 18)
            {
                Quote += 100m;
            }

            else if (age >= 19 && age <= 25)                                    //  This is the payment amount if the customer's age is between 19-25
            {
                Quote += 50m;
            }

            else if (age >= 26)                                                  //  This statement adds $25 if the customer's age is 26 or older than

            {
                Quote += 25m;
            }
            //  Age claculation ended
            //  Car year calculation
            if (insuree.CarYear < 20000)
            {
                Quote += 25m;
            }
            else if (insuree.CarYear > 2015)
            {
                Quote += 25m;
            }
            //  Car year calculation ended
            //  Car Make calculation
            if (insuree.CarMake == "Porsche")
            {
                Quote += 25m;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                Quote += 25m;
            }
            //  Specific car model calculation ended
            //  Ticket calculation
            Quote += 10 * insuree.SpeedingTickets;
            if (insuree.DUI == true)
            {
                Quote *= 0.25m;                 //  If the customer has DUI, this will add 25% to the total amount
            }
            //  Ticket calculation ended
            //  Coverage type calculation
            if (insuree.CoverageType == true)
            {
                Quote += 0.5m;
            }
            Quote = insuree.Quote;              //  Saves the value of calculated quote to the insuree.quote property
            //  coverage type calculation ended
            return View(Quote);
        }



        //Admin View
        public ActionResult Admin()

        {
            var Quote = (from insuree in db.Insurees
                         select new QViewModel
                         {
                             FirstName = insuree.FirstName,
                             LastName = insuree.LastName,
                             EmailAddress = insuree.EmailAddress,
                         }).ToList();
            return View(Quote);
        }

        public class QViewModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
        }
    }
}



