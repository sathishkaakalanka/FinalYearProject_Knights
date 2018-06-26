using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
using BusinessEntity;
using BusinessBL;
=======
using System.Web.Routing;
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819

namespace StockMarketsimulationGame.Controllers
{
    public class DashboardController : Controller
    {
        private static string SelectedPlayer;
        private static float AvailableMoney;
        // GET: Dashboard
        public ActionResult Index()
        {    
            ViewBag.Money = AvailableMoney;
            return View();
        }
        public ActionResult Transaction()
        {
            ViewBag.Money = AvailableMoney;
            GetSectors();
            return View();
        }

        public ActionResult Analyst()
        {
            return View();
        }

        public ActionResult Player()
        {
            AvailableMoney = 1000;
            return View();
        }
<<<<<<< HEAD
        public ActionResult GetPlayer(string Player)
        {
            SelectedPlayer = Player;
            return View();

        }
        public void GetSectors()
        {
            var SectorsDetails = new TransationBL().GetBrokerDetail();
            ViewBag.Sectors = SectorsDetails.Select(x => new SelectListItem
            {
                Text = x.SectorName,
                Value = x.SectorId.ToString()
            }).ToList();
        }
        public ActionResult GetCompaneyDetails(string ID)
        {
            var CompaneyDetails = new TransationBL().GetCompaneyDetails(Guid.Parse(ID));
            return Json(new { Items = CompaneyDetails });
        }
        public ActionResult GetBuyDetails(float Price)
        {
            AvailableMoney = AvailableMoney - Price;
            return Redirect("Index");

        }  
=======

        public ActionResult Broker()
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

        public ActionResult Player2()
        {
            return View();
        }

        public ActionResult Player3()
        {
            return View();
        }
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
    }
}
