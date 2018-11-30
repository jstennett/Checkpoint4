using Blow_Out.DAL;
using Blow_Out.Models;
using Blow_Out.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blow_Out.Controllers
{
    //Author: Jordan Stenentt
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
                db.SaveChanges();
                db.Instruments.First(x => x.InstrumentID == instrumentID).CustomerID = customer.CustomerID;
                db.SaveChanges();
                SummaryView summaryView = new SummaryView();
                summaryView.Instrument = db.Instruments.Find(instrumentID);
                summaryView.Customer = db.Customers.Find(customer.CustomerID);
                return View("Summary", summaryView);
            }

            return View(instrumentID);
        }

        public ActionResult EditCustomer(int customerID)
        {
            Customer customer = db.Customers.Find(customerID);


            return View(customer);
        }
        [HttpPost]
        public ActionResult EditCustomer([Bind(Include = "CustomerID,FirstName,LastName,Address,City,State,Email,Phone, Zipcode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UpdateData");
            }
            return View(customer);
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            if (UserName == "Missouri" && Password == "ShowMe")
            {
                return RedirectToAction("UpdateData");
            }

            return View();
        }

        public ActionResult UpdateData()
        {
            UpdateDataView updateDataView = new UpdateDataView();

            updateDataView.instruments = db.Instruments.ToList();
            updateDataView.customers = db.Customers.ToList();

            return View(updateDataView);
        }

        public ActionResult DeleteCustomer(int? customerID)
        {
            if (customerID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(customerID);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var result = db.Instruments.SingleOrDefault(b => b.CustomerID == customerID);
            if (result != null)
            {
                result.CustomerID = null;
                db.SaveChanges();
            }

            db.Customers.Remove(customer);
            db.SaveChanges();

            return RedirectToAction("UpdateData");
        }
    }
}