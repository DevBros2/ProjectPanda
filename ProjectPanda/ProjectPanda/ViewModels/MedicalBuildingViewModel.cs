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
        float ChartValue;
        public ObservableCollection<MedicalBuildingModel> Practices { get; set; }
        public object SelectedItem { get; set; }

        public MedicalBuildingViewModel()
        {
            GenerateMedicalBuildingModel();
            PopulateCharts();
        }

        #region ListViewData
        private void GenerateMedicalBuildingModel()
        {
            Practices = new ObservableCollection<MedicalBuildingModel>
            {
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",Distance = 6.2,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "CromptomHospital",Distance = 8,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "GrooteSchuurHospital",Distance = 9.7,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "PinetownClinic",Distance = 13.3,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "WestvilleHospital",Distance = 15.0,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Medicross:Pinetown",Distance = 18.5,ChartValue = this.ChartValue= 100},
                new MedicalBuildingModel{ ProfileImage="GreysHospital.jpg", PracticeName = "Grey's Hospital", Distance = 20.2,ChartValue = this.ChartValue= 100},


            };

            //ChartValue = this.ChartValue;
        }


        private void PopulateCharts()
        {
            List<Entry> entries = new List<Entry>
            {
                 new Entry(ChartValue)
                 {Color = SKColor.Parse("#00ff00"),Label = ChartValue.ToString(),ValueLabel = "25"//Green
                 },

                new Entry(ChartValue)
                { Color = SKColor.Parse("#ff0000"), Label = "Data!", ValueLabel = "27" },

                new Entry(ChartValue)
                { Color = SKColor.Parse("#c5ff99"), Label = "Data!", ValueLabel = "200"},

                new Entry(ChartValue)
                { Color = SKColor.Parse("#FF4500"), Label = "Data!", ValueLabel = "50" },

                new Entry(ChartValue)
                { Color = SKColor.Parse("#c5ff99"),Label = "Data!",ValueLabel = "200"},

                new Entry(ChartValue)
                { Color = SKColor.Parse("#FF4500"), Label = "Data!",ValueLabel = "64" },//Orange

                new Entry(ChartValue)
                { Color = SKColor.Parse("#ff0000"),Label = "Data!", ValueLabel = "85"}//Red
            };
            #endregion

        }
    }
}
