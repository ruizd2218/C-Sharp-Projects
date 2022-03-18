using NewsletterAppMVC.ViewModels;
using NewsletterAppMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUps.where(x => x.Removed == null).ToList();
                var SignupVMs = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignupVM();
                    signupVM.ID = signup.ID;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    SignupVMs.Add(signupVM);
                }

                return View(SignupVMs);
            }
        }
    }
}