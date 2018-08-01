using System;
using System.Collections.Generic;
using System.Text;
using Microcharts;
using ProjectPanda.Models.AppointmentModels;

namespace ProjectPanda.Models
{
    public class MedicalBuildingModel
    {
        public string Id { get; set; }
        public string MedicalBuildingImage { get; set; }
        public string PracticeName { get; set; }
        public float ChartValue { get; set; } //This Must be value 0 - 100%
        public Chart ChartData { get; set; }
        public double Distance { get; set; }
        public PracticeLocation Address{get; set;}
        public int PatientsCurrentlyAtPractice{ get; set; }
        public double AvgTimeSpent { get; set; } //The average time a pateint spends at a practice
        public DocAvaliable doctor { get; set; }
        public Specilization FieldsSpecilized { get; set; }
    }
}
