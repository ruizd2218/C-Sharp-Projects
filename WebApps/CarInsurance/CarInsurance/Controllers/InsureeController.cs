using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode1,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                using (var db = new InsuranceEntities())
                {
                   
                    var quoteCalc = new Insuree();
                    decimal q = quoteCalc.Quote;
                    q = 50M;
                    DateTime now = DateTime.Today;
                    DateTime Eighteen = now.AddYears(-18);
                    DateTime TwentyFive = now.AddYears(-25);

                    decimal birth = 0;
                    decimal year = 0;
                    decimal porsche = 0;
                    decimal carrera = 0;
                    decimal tickets = 0;
                    decimal DUI = 0;
                    decimal CT = 0;

                    if (quoteCalc.DateOfBirth >= Eighteen)
                    {
                        birth = q + 100;
                    }
                    else if (quoteCalc.DateOfBirth < Eighteen && quoteCalc.DateOfBirth > TwentyFive)
                    {
                        birth = q + 50;
                    }
                    else if (quoteCalc.DateOfBirth < TwentyFive)
                    {
                        birth = q + 25;
                    }

                    if (quoteCalc.CarYear < 2000 || quoteCalc.CarYear > 2015)
                    {
                        year = q + 25;
                    }

                    if (quoteCalc.CarMake == "Porsche")
                    {
                        porsche = q + 25;
                    }

                    if (quoteCalc.CarMake == "Porsche" || quoteCalc.CarMode1 == "911 Carrera")
                    {
                        carrera = q + 25;
                    }


                    for (int i = 1; i == quoteCalc.SpeedingTickets; i = i + 1)
                    {
                        tickets = q + 10;
                    }

                    if (quoteCalc.DUI == true)
                    {
                        DUI = q + 25 / 100;
                    }

                    if (quoteCalc.CoverageType == true)
                    {
                        CT = q + 50 / 100;
                    }

                    decimal finalQuote = birth + year + porsche + carrera + tickets + DUI + CT;

                    quoteCalc.Quote = finalQuote;
                }
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarMode1,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
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

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
