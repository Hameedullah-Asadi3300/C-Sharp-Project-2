using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        public double BasePayment(Insuree insuree)
        {
            //  This is the base payment
            double payment = 50;

            //  Customer's age calculation
            int customersAge = DateTime.Now - insuree.DateofBirth.Year;

            //  If statement to add more payment if age <= 18
            if (customersAge <= 18)
            {
                payment += 100;
            }

            //  This is the payment amount if the customer's age is between 19-25
            else if (customersAge <= 25)
            {
                payment += 50;
            }

            //  This statement adds $25 if the customer's age is 26 or older than
            else if (customersAge >= 26)
            {
                payment += 25;
            }
            //  Age claculation ended

            //  Car year calculation
            if (insuree.CarYear < 20000)
            {
                payment += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                payment += 25;
            }
            //  Car year calculation ended

            //  Car Make calculation
            if (insuree.CarMake == "Porsche")
            {
                payment += 25;
            }
            if (insuree.CarMake == "Porsche" || insuree.CarModel == "911 Carrera")
            {
                payment += 25;
            }
            //  Specific car model calculation ended

            //  Ticket calculation
            payment += 10 * insuree.SpeedingTickets;
            if (insuree.DUI == true)
            {
                payment *= 25;  //  If the customer has DUI, this if stetement and condition will add 25% to the total amoiunt should be paid
            }
            //  Ticket calculation ended

            //  Coverage type calculation
            if (insuree.CoverageType == true)
            {
                payment += 0.5;
            }
            //  coverage type calculation ended
            return payment;
        }

            //  Admin view
        public ActionResult Admin()
        {
            var payment = (from insuree in db.Insurees
                           select new PropertyView
                           {
                               FirstName = insuree.FirstName,
                               LastName = insuree.LastName,
                               EmailAddress = insuree.EmailAddress
                           }).ToList();
            return View(payment);                   
        }  
        

        public class PropertyView
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
        }


    }
}


