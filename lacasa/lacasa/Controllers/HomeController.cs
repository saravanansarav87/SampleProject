using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lacasa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact_Us()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact_Us(string fname, string lname, string email, string phno, string mesg, string subject)
        {
            string from = "info@onlinenewsmedia.in";
            const string SERVER = "relay-hosting.secureserver.net";
            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient();

                {
                    msg.To.Add("maillacasagrill@gmail.com");
                    msg.Subject = "Contact Form";
                    msg.Body = msg.Body = "<table border='1'>"
                + "<tr>" + "<th>" + "First Name : " + "</th>" + "<td>" + fname + "</td>" + "</tr>"
                + "<tr>" + "<th>" + "Email Address : " + "</th>" + "<td>" + email + "</td>" + "</tr>"
                + "<tr>" + "<th>" + "Phone Number : " + "</th>" + "<td>" + phno + "</td>" + "</tr>"
                + "<tr>" + "<th>" + "Message : " + "</th>" + "<td>" + mesg + "</td>" + "</tr>"
                + "</table>";
                    msg.IsBodyHtml = true;
                    msg.From = new System.Net.Mail.MailAddress(from);
                    msg.Priority = System.Net.Mail.MailPriority.High;
                    sc.Host = SERVER;
                    sc.Send(msg);
                }
            }
            TempData["Sentcontact"] = "Thank you. We will get back to you soon.";
            ViewBag.Message = "Sent";
            TempData["contact"] = "<script>alert('Thank you. We will get back to you soon!');</script>";
            ModelState.Clear();
            Contact_Us();
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Home_Delivery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Opening_Hours()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Facilities()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lacasa_Special()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Book_Menu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       



    }
}