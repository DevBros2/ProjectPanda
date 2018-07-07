using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

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
            Scan();
        }
        public async void Scan()
        {
            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {

                //scan instance
                ScannerPage.IsScanning = false;
                // Alert with customers name
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Customer Name here", result.Text, "OK");
                });
            };


            await Navigation.PushAsync(ScannerPage);

        }

    }
}