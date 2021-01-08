using NewletterAppMVC.Models;
using NewletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            // Enitiy Framework
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // Lambda syntax to add removed items to an Unsubscribed list
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                // Linq syntax to add removed items to an Unsubscribed list
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();

                var signupVMs = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignupVM();
                    signupVM.id = signup.id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVM);
                }

                return View(signupVMs);
            }
        }

        public ActionResult Unsubscribe(int id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}