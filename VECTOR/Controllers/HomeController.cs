using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VECTOR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }
        public ActionResult TeamProfile()
        {
            ViewBag.Current = "TeamProfile";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ProjectStatus()
        {
            ViewBag.Current = "ProjectStatus";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";
            ViewBag.Current = "Contact";
            return View();
        }

        public ActionResult Tools()
        {
            ViewBag.Current = "Tools";
            return View();
        }
        public ActionResult Documentation()
        {
            ViewBag.current = "Documentation";
            return View();
        }
        public ActionResult Innovation()
        {
            ViewBag.current = "Innovation";
            return View();
        }
        public ActionResult Innovate1() {
            ViewBag.current = "Innovation";
            return View();
        }
        public ActionResult Environments() {
            ViewBag.current = "Environments";
            return View();
        }

    }
}