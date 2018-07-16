using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models.AppointmentModels
{
    public class PracticeLocation
    {
        public string AddressLine1 { get; set; }
        public string AddreesLine2 { get; set; }
        public string TownOrCity { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PracticeNumber { get; set; }
        public double Latitude { get; set; } 
        public double Longitude { get; set; } 
    }
}
