using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var InsQuo = new List<InsuranceVM>();
                foreach (var quotes in InsQuo)
                {
                    var InsuranceVM = new InsuranceVM();
                    InsuranceVM.Quote = InsuranceVM.Quote;
                    InsuranceVM.FirstName = InsuranceVM.FirstName;
                    InsuranceVM.LastName = InsuranceVM.LastName;
                    InsuranceVM.EmailAddress = InsuranceVM.EmailAddress;
                    
                    InsQuo.Add(InsuranceVM);
                }

                return View(InsQuo);
            }
        }
    }
}