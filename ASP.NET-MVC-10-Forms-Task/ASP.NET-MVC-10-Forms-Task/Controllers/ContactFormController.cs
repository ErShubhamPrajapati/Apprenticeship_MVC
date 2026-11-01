using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_10_Forms_Task.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name,long? mobile,string email,string message)
        {
            Response.Write($"Name = {name}\n");
            Response.Write($"Mobile No. = {mobile}\n");
            Response.Write($"Email = {email}\n");
            Response.Write($"Message = {message}\n");
            return Content("");
        }
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Student( string name,int? age, string course,string collegename,string address)
        {
            Response.Write($"Name = {name}\n");
            Response.Write($"Age = {age}\n");
            Response.Write($"Course = {course}\n");
            Response.Write($"College Name = {collegename}\n");
            Response.Write($"Address = {address}\n");
            return Content("");
        }

        public ActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Employee(string employeename, string department, string designation, decimal? salary, DateTime? joiningdate)
        {
            Response.Write($"Employee Name = {employeename}<br/>");
            Response.Write($"Department = {department}<br/>");
            Response.Write($"Designation = {designation}<br/>");
            Response.Write($"Salary = {salary}<br/>");
            Response.Write($"Joining Date = {joiningdate}<br/>");

            return Content("");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(string username, string email, string password, string gender, DateTime? dob)
        {
            Response.Write($"Username = {username}<br/>");
            Response.Write($"Email ID = {email}<br/>");
            Response.Write($"Password = {password}<br/>");
            Response.Write($"Gender = {gender}<br/>");
            Response.Write($"Date of Birth = {dob}<br/>");

            return Content("");
        }


        public ActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Product(string productname, int? quantity, string category, string description)
        {
            Response.Write($"Product Name = {productname}<br/>");
            Response.Write($"Quantity = {quantity}<br/>");
            Response.Write($"Category = {category}<br/>");
            Response.Write($"Description = {description}<br/>");

            return Content("");
        }

        public ActionResult Address()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Address(int? housenumber, string street, string city, string state, int? pincode)
        {
            Response.Write($"House Number = {housenumber}<br/>");
            Response.Write($"Street = {street}<br/>");
            Response.Write($"City = {city}<br/>");
            Response.Write($"State = {state}<br/>");
            Response.Write($"PIN Code = {pincode}<br/>");

            return Content("");
        }

        public ActionResult Course()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Course(string coursename, string duration, string coursemode, decimal? fees, string instructorname)
        {
            Response.Write($"Course Name = {coursename}<br/>");
            Response.Write($"Duration = {duration}<br/>");
            Response.Write($"Course Mode = {coursemode}<br/>");
            Response.Write($"Fees = {fees}<br/>");
            Response.Write($"Instructor Name = {instructorname}<br/>");

            return Content("");
        }

        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(string customername, string email, int? rating, string servicetype, string comments)
        {
            Response.Write($"Customer Name = {customername}<br/>");
            Response.Write($"Email ID = {email}<br/>");
            Response.Write($"Rating = {rating}<br/>");
            Response.Write($"Service Type = {servicetype}<br/>");
            Response.Write($"Comments = {comments}<br/>");

            return Content("");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string role)
        {
            Response.Write($"Username = {username}<br/>");
            Response.Write($"Password = {password}<br/>");
            Response.Write($"Role = {role}<br/>");

            return Content("");
        }

        public ActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointment(string patientname, int? age, string mobile, string doctorname, DateTime? appointmentdate, string appointmenttime)
        {
            Response.Write($"Patient Name = {patientname}<br/>");
            Response.Write($"Age = {age}<br/>");
            Response.Write($"Mobile Number = {mobile}<br/>");
            Response.Write($"Doctor Name = {doctorname}<br/>");
            Response.Write($"Appointment Date = {appointmentdate}<br/>");
            Response.Write($"Appointment Time = {appointmenttime}<br/>");

            return Content("");
        }
    }
}