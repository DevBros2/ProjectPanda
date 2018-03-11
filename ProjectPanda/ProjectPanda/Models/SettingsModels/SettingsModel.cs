using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class SettingsModel
    {

        //computation time is wasted here, why are these primative bonga?

        public String AddressLine { get; set; }
        public String AddressLine2 { get; set; }
        public String CityOrTown { get; set; }
        public String Blood { get; set; }
        public String MedicalAid { get; set; }
        public String Postal_Code { get; set; }
        public String Cellphone_Number { get; set; }
        public String Email { get; set; }
    }
}
