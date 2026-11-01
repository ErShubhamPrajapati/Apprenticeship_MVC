using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //Partial view result used to return partical 
     //public PartialViewResult index()
     //   {
     //       return PartialView();
     //   }

        //content result is used to returen any content directly on browser
        //public ContentResult Message()
        //{
        //    return Content("<script>alert('<h1>Shubham</h1>')</script>");
        //}

        //RedirectToRouteResult: to redirect the comming to request to another request
        //public RedirectToRouteResult Login()
        //{
        //    return RedirectToAction("index");
        //}

        //Login
         
        //public ActionResult Login()
        //{
        //    if (true)
        //    {
        //        return RedirectToAction("dashboard","User");

        //    }
        //    else
        //    {
        //        return RedirectToAction("<script>alert('invalid')</script>");
        //    }
        //}


        //public RedirectResult Hello()
        //{
        //    return Redirect("http://shubhamtech.runasp.net/");
        //}


        //public FileResult Download()
        //{
        //    return File(" /Content/.../abc.png" ,"image/*");
        //}



        //method overloading
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(int a)
        {
            return View(); 
        }












    }
}