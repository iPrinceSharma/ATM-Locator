using ATMLocator.Database;
using ATMLocator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMLocator.Controllers
{   
    public class BankController : Controller { 

        public List<String> country = new List<string>{
            "Czech Republic"
        };

        public BankController()
        {
            ViewBag.Markers = "";
            ViewBag.Country = country;
            ViewBag.states = new List<String>();
            ViewBag.banks = new List<String>();
        }

        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }

        [Route("states/{countryName}")]
        public ActionResult getStateNames(string countryName){

            List<String> tempnames = new List<string>();
            if (!String.IsNullOrEmpty(countryName))
            {
                String stateNamesQuery = "SELECT * FROM Bank WHERE Country ='" + countryName + "' order by State";
                List<Bank> stateNames = (List<Bank>)DatabaseUtility.Instance.ExcuteObject<Bank>(stateNamesQuery);
                foreach (var item in stateNames)
                {
                    if (tempnames.IndexOf(item.State) == -1)
                    {
                        tempnames.Add(item.State);
                    }
                }
            }
            return Json(tempnames, JsonRequestBehavior.AllowGet);
        }

        [Route("banks/{stateName}")]
        public ActionResult getBankNames(string stateName)
        {
            List<String> tempnames = new List<string>();
            if (!String.IsNullOrEmpty(stateName))
            {
                String bankNamesQuery = "SELECT * FROM Bank WHERE State ='" + stateName + "' order by Name";
                List<Bank> bankNames = (List<Bank>)DatabaseUtility.Instance.ExcuteObject<Bank>(bankNamesQuery);
              
                foreach (var item in bankNames)
                {
                    if (tempnames.IndexOf(item.State) == -1)
                    {
                        tempnames.Add(item.Name);
                    }
                }
            }
            return Json(tempnames, JsonRequestBehavior.AllowGet);
        }

        [Route("coordinates")]
        public ActionResult getATMCoordinates(String stateName, string bankName)
        {
            List<mapLocation> locationList = new List<mapLocation>();
            String bankNamesQuery;

            if (!String.IsNullOrEmpty(bankName)){
                bankNamesQuery = "SELECT * FROM ATM WHERE State ='" + stateName +"' AND BankName ='"+bankName+"' order by Name";
            }
            else{
                bankNamesQuery = "SELECT * FROM ATM WHERE State ='" + stateName + "' order by Name";
            }
            List<ATM> locations = (List<ATM>)DatabaseUtility.Instance.ExcuteObject<ATM>(bankNamesQuery);
            foreach (var item in locations)
            {
                locationList.Add(new mapLocation(item.Name, item.Latitude, item.Longitude, item.Description));
            }

            return Json(locationList, JsonRequestBehavior.AllowGet);
        }
    }
}




