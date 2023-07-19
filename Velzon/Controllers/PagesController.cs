using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Velzon.Controllers
{
    public class PagesController : Controller
    {

        [ActionName("Starter")]
        public ActionResult Starter()
        {
            return View();
        }

        [ActionName("ProfileSimple")]
        public ActionResult ProfileSimple()
        {
            return View();
        }

        [ActionName("ProfileSettings")]
        public ActionResult ProfileSettings()
        {
            return View();
        }
        
        [ActionName("UserList")]
        public ActionResult UserList()
        {
            return View();
        }
        
        [ActionName("NewUser")]
        public ActionResult NewUser()
        {
            
            return View();
        }
        
        [HttpPost]
        [ActionName("NewUser")]
        public ActionResult NewUser(NewUser user)
        {
            return View();
        }
        
        [ActionName("Team")]
        public ActionResult Team()
        {
            return View();
        }

        [ActionName("Timeline")]
        public ActionResult Timeline()
        {
            return View();
        }

        [ActionName("FAQs")]
        public ActionResult FAQs()
        {
            return View();
        }

        [ActionName("Pricing")]
        public ActionResult Pricing()
        {
            return View();
        }

        [ActionName("Gallery")]
        public ActionResult Gallery()
        {
            return View();
        }

        [ActionName("Maintenance")]
        public ActionResult Maintenance()
        {
            return View();
        }

        [ActionName("ComingSoon")]
        public ActionResult ComingSoon()
        {
            return View();
        }

        [ActionName("Sitemap")]
        public ActionResult Sitemap()
        {
            return View();
        }

        [ActionName("SearchResults")]
        public ActionResult SearchResults()
        {
            return View();
        }

        [ActionName("PrivacyPolicy")]
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        [ActionName("TermConditions")]
        public ActionResult TermConditions()
        {
            return View();
        }

    }

    public class NewUser
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
