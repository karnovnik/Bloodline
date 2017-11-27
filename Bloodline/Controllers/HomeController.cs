using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bloodline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here I`ll say a couple of word about the project.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Сontact page.";

            return View();
        }
    }
}