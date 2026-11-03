using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class CollegeDashboardController : Controller
    {
        // GET: CollegeDashboard
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("collegeRegistration", "Registration");
        }
    }
}