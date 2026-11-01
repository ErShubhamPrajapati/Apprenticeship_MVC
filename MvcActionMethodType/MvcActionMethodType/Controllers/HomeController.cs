using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MvcActionMethodType.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name,long? mobile,string email)
        {
            //save data in database
            //return View;
            //return RedirectToAction("contact");
            Response.Write($"Name = {name}\n Mobile Number = {mobile}\n Email ID = {email}");
            return Content("");
        }

       
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }


    }
}