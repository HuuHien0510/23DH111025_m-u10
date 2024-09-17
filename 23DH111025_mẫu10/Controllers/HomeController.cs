using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH111025_mẫu10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index () 
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Text()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}