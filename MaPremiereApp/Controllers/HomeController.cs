using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaPremiereApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "2.2 Une page About qui vous présente";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "2.3 Une page contact qui affiche une carte de la rÃ©gion oÃ¹ vous habitez";

            return View();
        }

        public ActionResult Hobbies()
        {
            ViewBag.Message = "Une page Hobbies qui liste vos passions, Hobbies,...";

            return View();
        }
    }
}