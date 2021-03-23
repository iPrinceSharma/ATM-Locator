using ATMLocator.Database;
using ATMLocator.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMLocator.Controllers
{
    public class HomeController : Controller
    {
        private const string connectionString = "data source=DESKTOP-TMETLR5\\SQLEXPRESS; initial catalog=MyBank;Integrated Security=True";
  
        public ActionResult Index()
        {

            string markers = "[";
            String customeQuery = "Select * from Locations";

            List<Location>  result = (List<Location>)DatabaseUtility.Instance.ExcuteObject<Location>(customeQuery, false);

            foreach(var item in result){
                markers += "{";
                markers += string.Format("'title': '{0}',", item.Name);
                markers += string.Format("'lat': '{0}',", item.Latitude);
                markers += string.Format("'lng': '{0}',", item.Longitude);
                markers += string.Format("'description': '{0}'", item.Description);
                markers += "},";
            }
           

            markers += "];";
            ViewBag.Markers = markers;
            return View();
        }
    }
}