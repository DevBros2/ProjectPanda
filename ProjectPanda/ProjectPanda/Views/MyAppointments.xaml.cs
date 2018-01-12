using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAppointments : ContentPage
	{
		public MyAppointments ()
		{
			InitializeComponent ();
		}

        private  void Doctor_Button_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new MedicalBuildingView()); 
             NavigationPage nav=new NavigationPage(new MedicalBuildingView());
        }


        //the event handler for the date picker

        private void Datepick(object sender, DateChangedEventArgs args)
        {
          //
        }

    }
}