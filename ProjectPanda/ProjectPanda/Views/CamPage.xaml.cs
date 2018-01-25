using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Views.Scanner;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CamPage : ContentPage
	{
		public CamPage ()
		{
			InitializeComponent ();
		}


        private void ScanMeds(object sender, EventArgs e)
        {
            //takes the user to the Qr scanner 
            Navigation.PushAsync(new QrScanner());
        }

    }
}