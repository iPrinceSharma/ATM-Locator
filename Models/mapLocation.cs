using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMLocator.Models
{
    public class mapLocation
    {
        public string title { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string description { get; set; }

        public mapLocation(String title,string lat, string lng,string description)
        {
            this.title = title;
            this.lat = lat;
            this.lng = lng;
            this.description = description;
        }
    }
}