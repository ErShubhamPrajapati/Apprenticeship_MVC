using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Electronics()
        {
            return View();
        }

        public ActionResult Clothing()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult NewArrivals()
        {
            return View();
        }

        public ActionResult BestSellers()
        {
            return View();
        }
    }
}