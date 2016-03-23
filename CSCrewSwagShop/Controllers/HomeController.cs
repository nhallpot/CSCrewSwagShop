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
            int x = 3;
            int y = 4;
            int z = x + y;

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}