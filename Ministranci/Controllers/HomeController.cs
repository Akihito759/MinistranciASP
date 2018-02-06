using Ministranci.Builder;
using Ministranci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ministranci.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NavBar()
        {
            ViewBag.Message = "Your application description page.";

            return View("~/Views/Shared/_NavBar.cshtml");
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Patron()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Shifts()
        {
            var beginingDate = new DateTime(2018, 1, 21);
            var dateList = new List<DateTime>();

            for (int i = 0; i < 8; i++)
            {
                dateList.Add(beginingDate.AddDays(i));
            }
            return View(dateList);
        }
        
        public ActionResult Groups()
        {
            return View();
        }

        public ActionResult Koledy()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("_Temp");
        }

        public ActionResult HolyMassCreator()
        {
            return View();
        }
        public String Test(Dictionary<int,List<HolyMass>> dictionary,string date)
        {
            var x = new DailyHolyMassCreator(new DateTime(2018, 6, 2));
            var z = x.GetWeekHolyMassShifts(dictionary);
            string Json = null;

            return Json;
        }


    }
}
