using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionMethodType.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        // 1. Index
        public ActionResult Index()
        {
            return View();
        }

        // 2. Books
        public ActionResult Books()
        {
            return View();
        }

        // 3. AddBook
        public ActionResult AddBook()
        {
            return View();
        }

        // 4. BookDetails
        public ActionResult BookDetails()
        {
            return View();
        }

        // 5. Categories
        public ActionResult Categories()
        {
            return View();
        }

        // 6. Authors
        public ActionResult Authors()
        {
            return View();
        }

        // 7. Members
        public ActionResult Members()
        {
            return View();
        }

        // 8. IssueBook
        public ActionResult IssueBook()
        {
            return View();
        }

        // 9. ReturnBook
        public ActionResult ReturnBook()
        {
            return View();
        }

        // 10. FineDetails
        public ActionResult FineDetails()
        {
            return View();
        }
    
}
}