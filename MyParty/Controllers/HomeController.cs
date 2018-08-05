using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyParty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: rsvp
        public ActionResult rsvp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult rsvp(MyParty.Models.Person person)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", person);
            }
            else
            {
                return View();
            }
        }

    }
}