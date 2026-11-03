using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class StudentDashboardController : Controller
    {
        // GET: StudentDashboard
        public ActionResult Dashboard()
        {
            if (Session["name"] != null && Session["email"] != null)
                return View();
            else
                return RedirectToAction("Studentregistration","Registration");
        }
        public ActionResult Logout()
        {
            //Session.Remove("email");
            Session.RemoveAll();
            //Session.Abandon();
            return RedirectToAction("StudentRegistration","Registration");
        }


    }
}