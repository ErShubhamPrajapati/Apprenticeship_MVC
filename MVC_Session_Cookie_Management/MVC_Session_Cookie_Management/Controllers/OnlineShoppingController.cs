using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class OnlineShoppingController : Controller
    {
        // GET: OnlineShopping
        public ActionResult Dashboard()
        {
            if (Session["name"] != null && Session["email"] != null)
                return View();
            else
                return RedirectToAction("OnlineShopping", "Registration");
        }
        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("OnlineShopping", "Registration");
        }
    }
}