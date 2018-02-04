using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class MedicalBuildingModel
    {
        public string ProfileImage {get; set; }
        public string PracticeName { get; set; }
        public float ChartValue { get; set; } //This Must be value 0 - 100%
        public double Distance { get; set; }

    }
}
