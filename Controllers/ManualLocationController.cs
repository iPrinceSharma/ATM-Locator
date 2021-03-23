using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMLocator.Controllers
{
    public class ManualLocationController : Controller
    {
        public List<String> country = new List<string>{
            "Czechia",
            "Germany",
            "France",
            "Italy",
            "Swedan"
        };

        public List<String> AtnNames = new List<String>{
                "náměstí Republiky 1077/2 METRO Nám. Republiky (B Praha 1, 110 00 Praha 1, Czechia",
                "Malé náměstí 457/13 Dům u Zlaté koruny, Staré Město, 110 00 Praha, Czechia"
        };

        public ManualLocationController()
        {
            ViewBag.Country = country;
        }


        // GET: ManualLocation
        public ActionResult Index()
        {
            return View();
        }

        [Route("findCoordinates")]
        public ActionResult FindCoordinates(string address){
            List<String> locationList = new List<string>();

            // TO DO

            return Json(locationList, JsonRequestBehavior.AllowGet);
        }
    }
}