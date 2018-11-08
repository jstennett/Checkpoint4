using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blow_Out.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Response = "Please call Support at <u><strong> 801 - 555 - 1212</strong></u>. Thank you!";

            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Response = "Thank You <u><strong>" + name + "</strong></u>. We will send an email to <u><strong>" + email + "</strong></u>";

            return View("Index");
        }
    }
}