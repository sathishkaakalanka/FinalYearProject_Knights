using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess;

namespace StockMarketsimulationGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserLogin(string UserName, string Logged)
        {

            var LoggedUser = new LoggedUserUIProcess().GetLoggedUser(UserName, Logged);
            if (LoggedUser == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return RedirectToAction("Index", "UnauthorizedUser");
            }

        }

        public ActionResult CreateNewUser(string username, string Email, string Password)
        {
          
            var LoggedUser = new LoggedUserUIProcess().CreateNewUser(username, Email, Password);
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
            var Getpassword = new LoggedUserUIProcess().GetUserPassword(UserName);

            return Json(Getpassword);
        }

        //public static string base64Encodepassword(string Password) // Encode    
        //{
        //    try
        //    {
        //        byte[] encData_byte = new byte[Password.Length];
        //        encData_byte = System.Text.Encoding.UTF8.GetBytes(Password);
        //        string encodedData = Convert.ToBase64String(encData_byte);
        //        return encodedData;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error in base64Encode" + ex.Message);
        //    }
        //}
    }
}