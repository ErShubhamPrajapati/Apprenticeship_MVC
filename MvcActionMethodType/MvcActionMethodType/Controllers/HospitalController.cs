using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        // 1. Index
        public ActionResult Index()
        {
            return View();
        }

        // 2. Doctors
        public ActionResult Doctors()
        {
            return View();
        }

        // 3. Patients
        public ActionResult Patients()
        {
            return View();
        }

        // 4. Appointments
        public ActionResult Appointments()
        {
            return View();
        }

        // 5. Departments
        public ActionResult Departments()
        {
            return View();
        }

        // 6. Services
        public ActionResult Services()
        {
            return View();
        }

        // 7. Wards
        public ActionResult Wards()
        {
            return View();
        }

        // 8. Medicines
        public ActionResult Medicines()
        {
            return View();
        }

        // 9. Billing
        public ActionResult Billing()
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