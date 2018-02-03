using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Text;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;

using ProjectPanda.Models;

namespace ProjectPanda.ViewModels
{
    public class MedicalBuildingViewModel
    {
        //List<MyChart> MyCharts;
        public ObservableCollection<MedicalBuildingModel> Practices { get; set; }
        public object SelectedItem { get; set; }

        public MedicalBuildingViewModel()
        {
            GenerateMedicalBuildingModel();
            PopulateCharts();
        }

        private void GenerateMedicalBuildingModel()
        {
            Practices = new ObservableCollection<MedicalBuildingModel>
            {
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",Distance = 6.2,},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "CromptomHospital",Distance = 8,},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "GrooteSchuurHospital",Distance = 9.7,},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "PinetownClinic",Distance = 13.3,},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "WestvilleHospital",Distance = 15.0,},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Medicross:Pinetown",Distance = 18.5,},
                new MedicalBuildingModel{ ProfileImage="GreysHospital.jpg", PracticeName = "Grey's Hospital", Distance = 20.2,},


            };

        }

        private void PopulateCharts()
        {

        }
    }
}
