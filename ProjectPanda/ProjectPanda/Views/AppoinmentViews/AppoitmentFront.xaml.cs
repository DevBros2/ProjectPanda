using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppoitmentFront : ContentPage
	{
		public AppoitmentFront ()
		{
			InitializeComponent ();
		}



        async void Doctor_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctorListView());
            // var newpage = await NavigationPage(new DoctorListView());

        }


        //the event handler for the date picker

        private void Datepick(object sender, DateChangedEventArgs args)
        {
            //
        }

        private void Confirm(object sender, EventArgs e)
        {
          
        }


    }
}