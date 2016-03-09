using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //This is a cloning version.
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page."; 

            return View();
        }
    } // Changed by test_origin.
} //END //END again and again.
