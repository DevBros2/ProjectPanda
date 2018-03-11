using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectPanda.Helpers;
using ProjectPanda.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{

        #region Global variables

        bool workDelivEnabled;


        #endregion

        #region default constructor
        public Settings ()
		{
			InitializeComponent();
            //removes the second Navbar 
            NavigationPage.SetHasNavigationBar(this,false);
            NavigationPage.SetHasBackButton(this,true);
            
        }
        #endregion

        #region Properties

        #endregion


        #region the event handler for changing the distance proximty 
        private void KilometerChange(object sender, ValueChangedEventArgs args)
        {
            kilometerValue.Text = string.Format("{0}", args.NewValue);
        }
        #endregion

        #region Some Event handler by Bonga
        private async void User_0Settings_Clicked(object sender, EventArgs e)
        {
             Helpers.Settings.GeneralSettings = AddressLine.Text;
             Helpers.Settings.GeneralSettings = AddressLine2.Text;  
            Helpers.Settings.GeneralSettings = CityOrTown.Text;
            await Navigation.PopToRootAsync(true);
        }
        #endregion

        #region pick and convert the blood type to a text for saving -event handler
        private void Blood_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
              //  Blood.Text = picker.Items[selectedIndex];
               // BloodType.Text = picker.Items[selectedIndex];
            }
        }
        #endregion


        #region picks and converts the the medical aid picked to text -event handler
        private void Medical_Aid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == -1) { return; }

            else
            {
                string selcetedMedicalAid = picker.Items[selectedIndex];
            }
        }

        #endregion



        #region Switchcell Event handler

        private void switchWorkDelivery_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName== "workDelivEnabled")
            {
                
            }
        }

        #endregion

    }
}