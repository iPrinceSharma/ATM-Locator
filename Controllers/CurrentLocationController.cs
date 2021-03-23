using ATMLocator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMLocator.Controllers
{
    [RoutePrefix("currentLocation")]
    public class CurrentLocationController : Controller
    {
        private List<Location> listOfDummyLocation;
        public CurrentLocationController(){
            this.listOfDummyLocation = new List<Location>();
            listOfDummyLocation.Add(new Location("Rainy ATM", "50.082650","14.418890", "CP"));
            listOfDummyLocation.Add(new Location("Česká spořitelna", "50.075730","14.420050", "Česká spořitelna"));
            listOfDummyLocation.Add(new Location("Air Bank ATM", "50.082650","14.418890", "Air Bank ATM"));
        }


        // GET: CurrentLocation
        public ActionResult Index(){

            String markers = "[";
            foreach (var item in listOfDummyLocation){
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

        [Route("myPost")]
        public String SamplePostRequest(){
            return "Okay Checking the result";
        }

    }
}