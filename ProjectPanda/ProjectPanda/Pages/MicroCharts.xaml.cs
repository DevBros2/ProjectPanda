using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MicroCharts : ContentPage
	{
        List<MyChart> MyCharts;
        public MicroCharts ()
		{
			InitializeComponent ();
            MyCharts = new List<MyChart>();
            PopulateCharts();
        }
        #region ModelClass
        public class MyChart
        {
            public Chart ChartData { get; set; }
        }
        #endregion 

        private void PopulateCharts()
        {
            MyCharts.Add(new MyChart() { ChartData = Chart1 });
            MyCharts.Add(new MyChart() { ChartData = Chart2 });
            MyCharts.Add(new MyChart() { ChartData = Chart3 });
            MyCharts.Add(new MyChart() { ChartData = Chart4 });
           
            MyListview.ItemsSource = MyCharts;
        }
        public Chart Chart1 => new BarChart()
        {
            Entries = new[]
            {
                new Entry(128)
                {
                    Label = "iOS",
                    ValueLabel = "128",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(514)
                {
                     Label = "Shared",
                    ValueLabel = "514",
                    Color = SKColor.Parse("#3498db")
            }   },
                BackgroundColor = SKColors.White
        };

        public Chart Chart2 => new BarChart()
        {
            Entries = new[]
           {
                new Entry(128)
                {
                    Label = "iOS",
                    ValueLabel = "128",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(514)
                {
                     Label = "Shared",
                    ValueLabel = "514",
                    Color = SKColor.Parse("#3498db")
            }   },
            BackgroundColor = SKColors.White
        };

        public Chart Chart3 => new BarChart()
        {
            Entries = new[]
           {
                new Entry(128)
                {
                    Label = "iOS",
                    ValueLabel = "128",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(514)
                {
                     Label = "Shared",
                    ValueLabel = "514",
                    Color = SKColor.Parse("#3498db")
            }   },
            BackgroundColor = SKColors.White
        };

        public Chart Chart4 => new BarChart()
        {
            Entries = new[]
           {
                new Entry(128)
                {
                    Label = "iOS",
                    ValueLabel = "128",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(514)
                {
                     Label = "Shared",
                    ValueLabel = "514",
                    Color = SKColor.Parse("#3498db")
            }   },
            BackgroundColor = SKColors.White
        };


    }
}