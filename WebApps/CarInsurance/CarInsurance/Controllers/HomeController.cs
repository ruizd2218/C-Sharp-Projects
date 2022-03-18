using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Car Insurance";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us!";

            return View();
        }

        public ActionResult Quote()
        {
            using (var db = new InsuranceEntities())
            {             
                var quoteList = new List<Insuree>();
                foreach (var quote in quoteList)
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
            }
            return View();
        }
    }
}