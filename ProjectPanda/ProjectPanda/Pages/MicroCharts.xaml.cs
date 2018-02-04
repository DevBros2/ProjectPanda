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
        #region dummy data
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#c5ff99"),
                Label = "Data!",
                ValueLabel = "200"
            },
            new Entry(100)
            {
                Color = SKColor.Parse("#229122"),
                Label = "Data!",
                ValueLabel = "200"
            },
            new Entry(300)
            {
                Color = SKColor.Parse("#ff5252"),
                Label = "Data!",
                ValueLabel = "200"
            },
            new Entry(250)
            {
                Color = SKColor.Parse("#229122"),
                Label = "Data!",
                ValueLabel = "200"
            },
            new Entry(210)
            {
                Color = SKColor.Parse("#c5ff99"),
                Label = "Data!",
                ValueLabel = "200"
            },
        };
        #endregion
        public MicroCharts ()
		{
			InitializeComponent ();
            Chart1.Chart = new LineChart { Entries = entries };
        }
       
    }
}