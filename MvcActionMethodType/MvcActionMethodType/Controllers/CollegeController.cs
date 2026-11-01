using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class CollegeController : Controller
    {
        // GET: College
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

        // 3. Courses
        public ActionResult Courses()
        {
            return View();
        }

        // 4. Departments
        public ActionResult Departments()
        {
            return View();
        }

        // 5. Faculty
        public ActionResult Faculty()
        {
            return View();
        }

        // 6. Admissions
        public ActionResult Admissions()
        {
            return View();
        }

        // 7. Students
        public ActionResult Students()
        {
            return View();
        }

        // 8. Examinations
        public ActionResult Examinations()
        {
            return View();
        }

        // 9. Results
        public ActionResult Results()
        {
            return View();
        }

        // 10. Placements
        public ActionResult Placements()
        {
            return View();
        }
    }
}