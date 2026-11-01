using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
         // 1. Index
        public ActionResult Index()
        {
            return View();
        }

        // 2. Products
        public ActionResult Products()
        {
            return View();
        }

        // 3. Categories
        public ActionResult Categories()
        {
            return View();
        }

        // 4. ProductDetails
        public ActionResult ProductDetails()
        {
            return View();
        }

        // 5. Cart
        public ActionResult Cart()
        {
            return View();
        }

        // 6. Wishlist
        public ActionResult Wishlist()
        {
            return View();
        }

        // 7. Checkout
        public ActionResult Checkout()
        {
            return View();
        }

        // 8. Orders
        public ActionResult Orders()
        {
            return View();
        }

        // 9. Offers
        public ActionResult Offers()
        {
            return View();
        }

        // 10. CustomerSupport
        public ActionResult CustomerSupport()
        {
            return View();
        }
    }
}