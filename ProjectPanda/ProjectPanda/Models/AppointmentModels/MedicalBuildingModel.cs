using System;
using System.Collections.Generic;
using System.Text;
using Microcharts;

namespace ProjectPanda.Models
{
    public class MedicalBuildingModel
    {
        public string ProfileImage {get; set; }
        public string PracticeName { get; set; }
        public float ChartValue { get; set; } //This Must be value 0 - 100%
        public Chart ChartData { get; set; }
        public string Distance { get; set; }

    }
}
