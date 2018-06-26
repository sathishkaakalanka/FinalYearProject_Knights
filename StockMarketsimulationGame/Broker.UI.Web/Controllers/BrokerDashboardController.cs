using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broker.UI.Web.Controllers
{
    public class BrokerDashboardController : Controller
    {
        // GET: BrokerDashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}