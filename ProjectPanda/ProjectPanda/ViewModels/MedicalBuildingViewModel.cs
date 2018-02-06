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
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",ChartData = Chart1},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "CromptomHospital",ChartData = Chart2},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "GrooteSchuurHospital",ChartData = Chart3},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "PinetownClinic",ChartData = Chart4},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "WestvilleHospital",ChartData = Chart5},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Medicross:Pinetown",ChartData = Chart6},
                new MedicalBuildingModel{ ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",ChartData = Chart7},


            };

            //ChartValue = this.ChartValue;
        }

        public Chart Chart1 => new DonutChart()
        {
            Entries = new[]
            {
                new Entry(60)
                {
                    Label = "",
                    ValueLabel = "",
                     Color = SKColor.Parse("#FFFF00")//Yellow
                },
                 new Entry(40)
                {
                    Label = "",
                    ValueLabel = "",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
           BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart2 => new DonutChart()
        {
            Entries = new[]
            {
                new Entry(74)
                { 
                     Color = SKColor.Parse("#FF4500"),  
                },
                  new Entry(26)
                  {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                  },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart3 => new DonutChart()
        {
            Entries = new[]
           {
                new Entry(94)
                {
                     Color = SKColor.Parse("#ff0000")
                },
                 new Entry(6)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart4 => new DonutChart()
        {
            Entries = new[]
           {
                new Entry(85)
                {
                     Color = SKColor.Parse("#FFFF00")
                },
                 new Entry(15)
                 {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                 },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart5 => new DonutChart()
        {
            Entries = new[]
          {
                new Entry(80)
                {
                     Color = SKColor.Parse("#ff0000")
                },
                 new Entry(20)
                 {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                 },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart6 => new DonutChart()
        {
            Entries = new[]
            {
                new Entry(40)
                {
                     Color = SKColor.Parse("#00ff00")
                },
                 new Entry(60)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart7 => new DonutChart()
        {
            Entries = new[]
            {
                new Entry(25)
                {
                     Color = SKColor.Parse("#00ff00")
                },
                 new Entry(75)
                 {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                 },
            },
            BackgroundColor = SKColors.Transparent,
            MinValue = 0,
            MaxValue = 100
        };
        #endregion

    }
    
}
