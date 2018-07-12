using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectPanda.Helpers;
using ProjectPanda.ViewModels.SettingsViewModels;
//using ProjectPanda.Models; <<<MVVM aritecture not permit this dude
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
        SettingsViewModel viewModel;
        
        #region default constructor
        public Settings ()
		{
			InitializeComponent();
            //removes the second Navbar 
            NavigationPage.SetHasBackButton(this,true);
            viewModel = new SettingsViewModel();
            BindingContext = viewModel;
        }
        #endregion

        #region Properties

        #endregion


        #region the event handler for changing the distance proximty 
          void KilometerChange(object sender, ValueChangedEventArgs args)
        {
           // kilometerValue.Text = string.Format("{0}", args.NewValue);
        }
        #endregion

        #region Some Event handler by Bonga
        private async void User_0Settings_Clicked(object sender, EventArgs e)
        {
            // Helpers.Settings.GeneralSettings = AddressLine.Text;
           //  Helpers.Settings.GeneralSettings = AddressLine2.Text;  
          //  Helpers.Settings.GeneralSettings = CityOrTown.Text;
            await Navigation.PopToRootAsync(true);
        }
        #endregion

        #region Might have Two delete these two cause the custom view cell view model class has the code for it

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

        #endregion

        #region Switchcell Event handler

        
        #endregion


    }
}