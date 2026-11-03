using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class EmployeeRegistrationController : Controller
    {
        // GET: EmployeeRegistration
        public ActionResult Dashboard()
        {
            if (Session["email"] != null && Session["department"] != null)
                return View();
            else
                return RedirectToAction("EmployeeRegistration", "Registration");
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("EmployeeRegistration","Registration");
        }
    }
}