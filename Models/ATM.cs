using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ATMLocator.Models
{
    public class ATM
    {
        public string Name { get; set; }
        public string BankName { get; set; }
        public string State { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
  
        public string Description { get; set; }

        public ATM(DataRow data)
        {
            this.Name = data["Name"].ToString();
            this.BankName = data["BankName"].ToString();
            this.State = data["State"].ToString();
            this.Description = data["Description"].ToString();
            this.Latitude = data["Latitude"].ToString();
            this.Longitude =data["Longitude"].ToString();
        }
    }
}