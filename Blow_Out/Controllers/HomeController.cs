using Blow_Out.Models;
using Blow_Out.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blow_Out.Controllers
{
    public class HomeController : Controller
    {
        public static List<Instrument> instruments = new List<Instrument>();

        public ActionResult Index()
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

        public ActionResult Rentals()
        {
            if (instruments.Count < 1)
            {
                instruments.Add(new Instrument { name = "Trumpet", priceNew = 55, priceOld = 25, image = "../../Content/images/Trumpet.png" });
                instruments.Add(new Instrument { name = "Trombone", priceNew = 60, priceOld = 35, image = "../../Content/images/Trombone.jpg" });
                instruments.Add(new Instrument { name = "Tuba", priceNew = 70, priceOld = 50, image = "../../Content/images/Tuba.jpg" });
                instruments.Add(new Instrument { name = "Flute", priceNew = 40, priceOld = 25, image = "../../Content/images/Flute.jpg" });
                instruments.Add(new Instrument { name = "Clarinet", priceNew = 35, priceOld = 27, image = "../../Content/images/Clarinet.jpg" });
                instruments.Add(new Instrument { name = "Saxaphone", priceNew = 42, priceOld = 30, image = "../../Content/images/Saxaphone.jpg" });
            }

            return View(instruments);
        }

        public ActionResult Instrument(int id)
        {
            InstrumentView instrumentView = new InstrumentView() { instrumentId = id, instruments = instruments};

            return View("Instrument", instrumentView);
        }
    }
}