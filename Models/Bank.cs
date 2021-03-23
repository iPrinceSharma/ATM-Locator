using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ATMLocator.Models
{
    public class Bank
    {
        public string Name { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Description { get; set; }
        
        public Bank(DataRow data)
        {
            this.Name = data["Name"].ToString();
            
            this.State = data["State"].ToString();
            this.StateCode = data["StateCode"].ToString();

            this.Country = data["Country"].ToString();
            this.CountryCode = data["CountryCode"].ToString();
            
            this.Description = data["Description"].ToString();
        }

    }
}


