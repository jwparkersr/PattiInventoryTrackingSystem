using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PattiInventoryTrackingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "PITS is an inventory tracking system used for managing supplies at Patti's Shipyard Inc.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Patti's Shipyard Inc.";

            return View();
        }
    }
}