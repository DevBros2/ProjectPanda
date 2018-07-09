using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public DateTime DateBooked { get; set; }
        public TimeSpan TimeBooked { get; set; }
        public MedicalBuildingModel buildingInformation { get; set; }
        public List<DateTime> datesNotTaken { get; set; } 

    }
}
