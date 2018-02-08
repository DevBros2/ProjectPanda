﻿using System;
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
                new MedicalBuildingModel{ Distance="7.8 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",ChartData = Chart1},
                new MedicalBuildingModel{ Distance="7 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "CromptomHospital",ChartData = Chart2},
                new MedicalBuildingModel{Distance="6 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "GrooteSchuurHospital",ChartData = Chart3},
                new MedicalBuildingModel{Distance="12 Km",  ProfileImage ="GreysHospital.jpg",PracticeName = "PinetownClinic",ChartData = Chart4},
                new MedicalBuildingModel{Distance="8 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "WestvilleHospital",ChartData = Chart5},
                new MedicalBuildingModel{Distance="5 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "Medicross:Pinetown",ChartData = Chart6},
                new MedicalBuildingModel{Distance="2 Km", ProfileImage ="GreysHospital.jpg",PracticeName = "Grey's Hospital",ChartData = Chart7},


            };

            //ChartValue = this.ChartValue;
        }

        public Chart Chart1 => new LineChart()
        {
            Entries = new[]
            {
                new Entry(60)//Indicates how busy it is
                {
                    Label = "8am",
                    ValueLabel = "",
                     Color = SKColor.Parse("#FFFF00")//Yellow
                },
                 new Entry(40)//then less value of the first Entry out of 100
                {
                    Label = "10am",
                    ValueLabel = "",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                new Entry(74) //Indicates how busy it is
                {
                    Label = "12pm",
                    Color = SKColor.Parse("#FF4500"),
                },
                new Entry(24) //Indicates how busy it is
                {
                    Label = "2pm",
                    Color = SKColor.Parse("#FF4500"),
                },
            },
           BackgroundColor = SKColors.Transparent,
           LabelTextSize = 18, 
           LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };

        public Chart Chart2 => new LineChart()
        {
            Entries = new[]
            {
                new Entry(74) //Indicates how busy it is
                {
                    Label = "8am",
                     Color = SKColor.Parse("#FF4500"),  
                },
                  new Entry(26)
                  {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                  },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart3 => new LineChart()
        {
            Entries = new[]
           {
                new Entry(85) //Indicates how busy it is
                {
                    Label = "8am",
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                    Label = "8am",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                new Entry(94) //Indicates how busy it is
                {
                    Label = "10am",
                     Color = SKColor.Parse("#ff0000")
                },
                 new Entry(6)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart4 => new LineChart()
        {
            Entries = new[]
           {
                new Entry(85) //Indicates how busy it is
                {
                    Label = "8am",
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                    Label = "10am",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                new Entry(85) //Indicates how busy it is
                {
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart5 => new LineChart()
        {
            Entries = new[]
          {
                new Entry(80)
                {
                    Label = "8am",
                     Color = SKColor.Parse("#ff0000")
                },
                new Entry(20)
                {
                    Label = "10am",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                new Entry(85) //Indicates how busy it is
                {
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart6 => new LineChart()
        {
            Entries = new[]
            {
                new Entry(40)
                {
                    Label = "8am",
                     Color = SKColor.Parse("#00ff00")
                },
                new Entry(60)
                {
                    Label = "10am",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                new Entry(85) //Indicates how busy it is
                {
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        public Chart Chart7 => new LineChart()
        {
            Entries = new[]
            {
                new Entry(25)
                {
                    Label = "8am",
                     Color = SKColor.Parse("#00ff00")
                },
                new Entry(75)
                {
                    Label = "10am",
                     Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
                 new Entry(85) //Indicates how busy it is
                {
                     Color = SKColor.Parse("#FFFF00")
                },
                new Entry(15)
                {
                    Color = SKColor.Parse("#D3D3D3")//Grey Color
                },
            },
            BackgroundColor = SKColors.Transparent,
            LabelTextSize = 18,
            LineSize = 7,
            MinValue = 0,
            MaxValue = 100
        };
        #endregion

    }
    
}
