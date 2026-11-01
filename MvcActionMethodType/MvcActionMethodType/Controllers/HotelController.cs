using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        // 1. Index
        public ActionResult Index()
        {
            return View();
        }

        // 2. About
        public ActionResult About()
        {
            return View();
        }

        // 3. Rooms
        public ActionResult Rooms()
        {
            return View();
        }

        // 4. RoomDetails
        public ActionResult RoomDetails()
        {
            return View();
        }

        // 5. Booking
        public ActionResult Booking()
        {
            return View();
        }

        // 6. Reservations
        public ActionResult Reservations()
        {
            return View();
        }

        // 7. Restaurant
        public ActionResult Restaurant()
        {
            return View();
        }

        // 8. Facilities
        public ActionResult Facilities()
        {
            return View();
        }

        // 9. Offers
        public ActionResult Offers()
        {
            return View();
        }

        // 10. Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}