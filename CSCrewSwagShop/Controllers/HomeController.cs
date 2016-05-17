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
            ViewBag.Year = DateTime.Now.Year.ToString();
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            return null;
        }

        public ActionResult EmailSend()
        {
            return View();
        }
    }
}