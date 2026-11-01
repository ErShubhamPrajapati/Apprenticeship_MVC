using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Practice_Tasks.Controllers
{
    public class FruitController : Controller
    {
        // GET: Fruit
        public ActionResult Index()
        {
            return View();
        }
    }
}