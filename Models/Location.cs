using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ATMLocator.Models
{
    public class Location
    {
        public String Name { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
        public String Description { get; set; }

        public Location(DataRow row){
            this.Name = row["Name"].ToString();
            this.Latitude = row["Latitude"].ToString();
            this.Longitude = row["Longitude"].ToString();
            this.Description = row["Description"].ToString();
        }

        public Location(String name,String lat, string lng,string description)
        {
            this.Name = name;
            this.Latitude = lat;
            this.Longitude = lng;
            this.Description = description;
        }

    }
}