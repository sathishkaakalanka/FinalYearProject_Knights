using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrokerUIProcess;

namespace Broker.UI.Web.Controllers
{
    public class BrokerHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserLogin(string UserName, string Logged)
        {

            var LoggedUser = new LoggedBrokerUIProcess().GetLoggedBroker(UserName, Logged);
            if (LoggedUser == true)
            {
                return RedirectToAction("Player", "Dashboard");
            }
            else
            {
                return RedirectToAction("Index", "UnauthorizedUser");
            }

        }

        public ActionResult CreateNewUser(string username, string Email, string Password)
        {

            var LoggedUser = new LoggedBrokerUIProcess().CreateNewBroker(username, Email, Password);
            string Message;
            if (LoggedUser == false)
            {
                Message = "User Created Successfully!";
            }
            else
            {
                Message = "User name is enterd, enter another user name!";
            }
            return Json(Message);
        }
        public ActionResult GetUserPassword(string UserName)
        {
            var Getpassword = new LoggedBrokerUIProcess().GetBrokerPassword(UserName);

            return Json(Getpassword);
        }

    }
}