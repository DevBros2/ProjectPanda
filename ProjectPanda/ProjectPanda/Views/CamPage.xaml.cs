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


        public async void Scan()
        {
            var ScannerPage=new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {
                // Parar de escanear
                ScannerPage.IsScanning = false;

                // Alert com o código escaneado
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Código escaneado", result.Text, "OK");
                });
            };


            await Navigation.PushAsync(ScannerPage);

        }




        private void ScanMeds(object sender, EventArgs e)
        {

            Scan();
        }

    }
}