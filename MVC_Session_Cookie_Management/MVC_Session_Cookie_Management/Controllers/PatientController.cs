using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult dashboard()
        {
            return View();
        }
        public ActionResult logout()
        {
            Session.RemoveAll();
            return View();
        }
    }
}