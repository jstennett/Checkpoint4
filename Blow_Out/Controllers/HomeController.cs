using Blow_Out.DAL;
using Blow_Out.Models;
using Blow_Out.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Blow_Out.Controllers
{
    public class HomeController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

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

            return View(db.Instruments.ToList());
        }

        public ActionResult Instrument(int instrumentID)
        {

            return View("Instrument", db.Instruments.Find(instrumentID));
        }

        public ActionResult RentInstrument(int instrumentID)
        {

            return View("AddCustomer", instrumentID);
        }
        
        [HttpPost]
        public ActionResult AddCustomer(Customer customer, int instrumentID)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.Instruments.First(x => x.InstrumentID == instrumentID).CustomerID = customer.CustomerID;
                db.SaveChanges();
                SummaryView summaryView = new SummaryView();
                summaryView.Instrument = db.Instruments.Find(instrumentID);
                summaryView.Customer = db.Customers.Find(customer.CustomerID);
                return View("Summary", summaryView);
            }

            return View(instrumentID);
        }
    }
}