using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Analysis()
        {
            ViewBag.Message = "OI rsrsrsrs.";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "Olha que daora yas.";

            return View();
        }

        public ActionResult Pollution()
        {
            ViewBag.Message = "Alterado por Yasmin, vê se foi aí aushahsuahsua";

            return View();
        }
    }
}