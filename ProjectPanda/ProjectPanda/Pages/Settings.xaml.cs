using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Helpers;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            //removes the second Navbar 
            NavigationPage.SetHasNavigationBar(this,false);
            NavigationPage.SetHasBackButton(this,true);
            
        }

        //the event handler for changing the distance proximty 
        private void KilometerChange(object sender, ValueChangedEventArgs args)
        {
            kilometerValue.Text = string.Format("{0}", args.NewValue);
        }

        private async void User_0Settings_Clicked(object sender, EventArgs e)
        {
            Helpers.Settings.GeneralSettings = AddressLine.Text;
            Helpers.Settings.GeneralSettings = AddressLine2.Text;
            Helpers.Settings.GeneralSettings = CityOrTown.Text;
            //Helpers.Settings.GeneralSettings = Blood_Type.Title;
            //Helpers.Settings.GeneralSettings = Medical_Aid.Text;
            
           
            await Navigation.PopToRootAsync(true);
        }

    }
}