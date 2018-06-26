using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockMarketsimulationGame.Controllers
{
    public class DashboardController : Controller
    {
        private static string SelectedPlayer;
        private static int AvailableMoney;
        // GET: Dashboard
        public ActionResult Index()
        {
            AvailableMoney = 1000;
            ViewBag.Money = AvailableMoney;
            return View();
        }
        public ActionResult Transaction()
        {
            return View();
        }

        public ActionResult Analyst()
        {
            return View();
        }

        public ActionResult Player()
        {
            return View();
        }
        public ActionResult GetPlayer(string Player)
        {
            SelectedPlayer = Player;
            return View();

        }
        
    }
}