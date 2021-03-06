﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrayerTimes.Models;
using PrayerTimes.ViewModels;

namespace PrayerTimes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Jame = new Masjid()
            {
                Name = "Jamia Masjid",
                Address = "2724 W granville ave 60659",
                PHnum = "123456789",
                Fajr = DateTime.Parse("5:20 AM"),
                Zuhr = DateTime.Parse("1:15 PM"),
                Asr = DateTime.Parse("6:30 PM"),
                Maghrib = DateTime.Parse("7:20 PM"),
                Isha = DateTime.Parse("9:00 PM"),
            };

            var REA = new Masjid()
            {
                Name = "Rahmat-E-Alam",
                Address = "3673 w northshore ave 60702",
                PHnum = "91234567",
                Fajr = DateTime.Parse("5:00 AM"),
                Zuhr = DateTime.Parse("1:10 PM"),
                Asr = DateTime.Parse("6:20 PM"),
                Maghrib = DateTime.Parse("7:00 PM"),
                Isha = DateTime.Parse("9:00 PM"),
            };

            var Noor = new Masjid()
            {
                Name = "Masjid-E-Noor",
                Address = "lol sumwhere on devon",
                PHnum = "679374920",
                Fajr = DateTime.Parse("5:00 AM"),
                Zuhr = DateTime.Parse("1:10 PM"),
                Asr = DateTime.Parse("6:20 PM"),
                Maghrib = DateTime.Parse("7:00 PM"),
                Isha = DateTime.Parse("9:00 PM"),
            };
            List<Masjid> Masjids = new List<Masjid> { Noor, REA, Jame };
            var viewmodel = new MasjidViewModel
            {
                Masjids = Masjids
            };

            return View(viewmodel);
        }


        public ActionResult Masjid(Masjid masjid)
        {
            return View(masjid);
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
    }
}