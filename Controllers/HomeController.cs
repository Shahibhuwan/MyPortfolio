using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using MyPortfolioManagement.Models;

namespace MyPortfolioManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(Email e)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress(e.email, e.Name);
                    var receiverEmail = new MailAddress("shahibhuwan5555@gmail.com", "Receiver");
                    var password = e.password;
                   
                    var body = e.Message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(e.email, e.password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = "PorFolio alert!",
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View(e);
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View(e);




        }
    }
}