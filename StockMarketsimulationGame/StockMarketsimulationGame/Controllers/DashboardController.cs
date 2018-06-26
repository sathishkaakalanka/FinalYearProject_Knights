using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
<<<<<<< HEAD
using BusinessEntity;
using BusinessBL;
=======
using System.Web.Routing;
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
=======
using System.Web.Routing;
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819

namespace StockMarketsimulationGame.Controllers
{
    public class DashboardController : Controller
    {
        private static string SelectedPlayer;
<<<<<<< HEAD
        private static int AvailableMoney;
=======
<<<<<<< HEAD
        private static int AvailableMoney;
=======
<<<<<<< HEAD
        private static int AvailableMoney;
=======
        private static float AvailableMoney;
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6
>>>>>>> edc4a44a78fea64be4965cd3b467230c358810bc
>>>>>>> b16180b9a49b8821f098d9c9b4cc8fbbe9a28332
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
<<<<<<< HEAD
=======
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
>>>>>>> b16180b9a49b8821f098d9c9b4cc8fbbe9a28332
            AvailableMoney = 1000;
            ViewBag.Money = AvailableMoney;
            return View();
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

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
<<<<<<< HEAD
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
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
            AvailableMoney = 1000;
            ViewBag.Money = AvailableMoney;
            return View();
        }
<<<<<<< HEAD
>>>>>>> edc4a44a78fea64be4965cd3b467230c358810bc
>>>>>>> b16180b9a49b8821f098d9c9b4cc8fbbe9a28332
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
        
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6
>>>>>>> edc4a44a78fea64be4965cd3b467230c358810bc
>>>>>>> b16180b9a49b8821f098d9c9b4cc8fbbe9a28332
    }
}
