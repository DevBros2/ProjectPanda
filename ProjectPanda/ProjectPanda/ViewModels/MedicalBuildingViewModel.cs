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
        //float ChartValue;
        public ObservableCollection<MedicalBuildingModel> Practices { get; set; }
        public object SelectedItem { get; set; }

        public MedicalBuildingViewModel()
        {
            GenerateMedicalBuildingModel();
           
        }

        #region ListViewData
        private void GenerateMedicalBuildingModel()
        {
            Practices = new ObservableCollection<MedicalBuildingModel>
            {
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",Distance = 6.2,
                ChartData = Chart1},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "CromptomHospital",Distance = 8,
                 ChartData = Chart2},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "GrooteSchuurHospital",Distance = 9.7,
                 ChartData = Chart3},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "PinetownClinic",Distance = 13.3,
                 ChartData = Chart4},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "WestvilleHospital",Distance = 15.0,
                 ChartData = Chart5},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Medicross:Pinetown",Distance = 18.5,
                 ChartData = Chart6},
                new MedicalBuildingModel{ ProfileImage="GreysHospital.jpg", PracticeName = "Grey's Hospital", Distance = 20.2,
                 ChartData = Chart7},


            };

            //ChartValue = this.ChartValue;
        }

        public Chart Chart1 => new BarChart()
        {
            Entries = new[]
            {
                new Entry(120)
                {
                    Label = "",
                    ValueLabel = "60%",
                     Color = SKColor.Parse("#FFFF00")
                },
            },
           BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart2 => new BarChart()
        {
            Entries = new[]
            {
                new Entry(148)
                {
                    Label = "",
                    ValueLabel = "75%",
                     Color = SKColor.Parse("#FF4500"),
                     
                },
                 
            },
            BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart3 => new BarChart()
        {
            Entries = new[]
           {
                new Entry(188)
                {
                    Label = "",
                    ValueLabel = "80%",
                     Color = SKColor.Parse("#ff0000")
                },

            },
            BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart4 => new BarChart()
        {
            Entries = new[]
           {
                new Entry(168)
                {
                    Label = "",
                    ValueLabel = "70%",
                     Color = SKColor.Parse("#FFFF00")
                },

            },
            BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart5 => new BarChart()
        {
            Entries = new[]
          {
                new Entry(208)
                {
                    Label = "",
                    ValueLabel = "84%",
                     Color = SKColor.Parse("#ff0000")
                },

            },
            BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart6 => new BarChart()
        {
            Entries = new[]
          {
                new Entry(80)
                {
                    Label = "",
                    ValueLabel = "40%",
                     Color = SKColor.Parse("#00ff00")
                },

            },
            BackgroundColor = SKColors.Transparent,
        };
        public Chart Chart7 => new BarChart()
        {
            Entries = new[]
          {
                new Entry(58)
                {
                    Label = "",
                    ValueLabel = "29%",
                     Color = SKColor.Parse("#00ff00")
                },

            },
            BackgroundColor = SKColors.Transparent,
        };
        #endregion

    }
    
}
