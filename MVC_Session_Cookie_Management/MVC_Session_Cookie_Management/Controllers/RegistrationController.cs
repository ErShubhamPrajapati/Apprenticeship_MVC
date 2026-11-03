using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVC_Session_Cookie_Management.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult StudentRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentRegistration(string name,string fname,string email, 
            string mobile, string course)
        {
            Session["name"] = name;
            Session["fname"] = fname;
            Session["email"] = email;
            Session["mobile"] = mobile;
            Session["course"] = course;
            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = name;
            cookie.Value = fname;
            //cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Expires = Convert.ToDateTime("2027-01-01");
            Response.Cookies.Add(cookie);
            return RedirectToAction("Dashboard", "StudentDashboard");
        }


        public ActionResult EmployeeRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeRegistration( string name,string email,string mobile,string department,
            string salary)
        {
            Session["name"] = name;
            Session["email"] = email;
            Session["mobile"] = mobile;
            Session["department"] = department;
            Session["salary"] = salary;
            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = name;
           
            //cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Expires = Convert.ToDateTime("2027-01-01");
            Response.Cookies.Add(cookie);
            return RedirectToAction("Dashboard","EmployeeRegistration");
        }
       

        public ActionResult CollegeRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CollegeRegistration(string name, string code,
    string email, string mobile, string address)
        {
            Session["name"] = name;
            Session["code"] = code;
            Session["email"] = email;
            Session["mobile"] = mobile;
            Session["address"] = address;

            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = name;
            cookie.Expires = Convert.ToDateTime("2027-01-01");

            Response.Cookies.Add(cookie);

            return RedirectToAction("Dashboard", "CollegeDashboard");
        }


        public ActionResult PatientRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PatientRegistration(string name, int age, string gender,
    string mobile, string address)
        {
            Session["name"] = name;
            Session["age"] = age;
            Session["gender"] = gender;
            Session["mobile"] = mobile;
            Session["address"] = address;

            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = name;
            cookie.Expires = Convert.ToDateTime("2027-01-01");

            Response.Cookies.Add(cookie);

            return RedirectToAction("Dashboard", "Patient");
        }

        public ActionResult OnlineShopping()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OnlineShopping(string name, string email,
            string product, int quantity, string address)
        {
            Session["name"] = name;
            Session["email"] = email;
            Session["product"] = product;
            Session["quantity"] = quantity;
            Session["address"] = address;

            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = name;
            cookie.Expires = Convert.ToDateTime("2027-01-01");

            Response.Cookies.Add(cookie);

            return RedirectToAction("Dashboard", "OnlineShopping");
        }
    }
}