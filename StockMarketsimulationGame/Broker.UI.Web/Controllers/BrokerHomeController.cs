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
            var ss = new LoggedBrokerUIProcess().checkwork();
            ViewBag.test = ss;
            return View();
        }


    }
}