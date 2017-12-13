using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Startsida()
        {
            return View();
        }

        public ActionResult Profil()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Vänner()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoggaIn()
        {
            return View();
        }

        public ActionResult Registrera()
        {
            return View();
        }

    }
}