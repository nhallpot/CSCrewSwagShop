using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSCrewSwagShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Get: About
        public ActionResult About()
        {
            return View();
        }

        // Get: Contact
        public ActionResult Contact()
        {
            return View();
        }


        // Post: Contact
        public ActionResult Contact(FormCollection form)
        {
            return null;
        }
    }
}