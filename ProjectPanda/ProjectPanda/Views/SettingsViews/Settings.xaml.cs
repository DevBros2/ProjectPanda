using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectPanda.Helpers;
using ProjectPanda.ViewModels.SettingsViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SQLite;
using ProjectPanda.Models;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage, INotifyPropertyChanged
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

            #region The Disabling of some code that is not needed at the time
            /*
            //set the bindingcontext of the Tableview
            SettingsViewModel switcher = new SettingsViewModel();
            settingProperty.BindingContext = switcher;

            //remove the work delivery section
            settingProperty.Root.Remove(deliveryAtWork);

            //propertychanged event handeler to spot for changes on the visual tree of the UI

            switcher.PropertyChanged+=(sender, args)=>
                    {
                        if (switcher.workDelivEnbaled && settingProperty.Root.IndexOf(deliveryAtWork) == -1)
                        {
                            settingProperty.Root.Add(deliveryAtWork);
                        }
                        else
                        {
                            if (!switcher.workDelivEnabled && settingProperty.Root.IndexOf(deliveryAtWork) != -1)
                            {
                                settingProperty.Root.Remove(deliveryAtWork);
                            }
                        }
                    };
                    */
            #endregion

        }
        #endregion

        #region Properties

        #endregion

        #region the event handler for changing the distance proximty 
          void KilometerChange(object sender, ValueChangedEventArgs args)
        {
            kilometerValue.Text = string.Format("{0}", args.NewValue);
        }
        #endregion

        #region Some Event handler 
        private async void User_0Settings_Clicked(object sender, EventArgs e)
        {
            SendInformationToLocalDb();
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

        #region Methods

        public void SendInformationToLocalDb()
        {
            Models.SettingsModel currentSettings = new Models.SettingsModel()
            {
                AddressLine = addressLine.Text,
                AddressLine2 = addressLine2.Text,
                CityOrTown = cityOrTown.Text,
               // Blood = bloodType.Text,
               // MedicalAid = medAid.Text,
                Postal_Code = postal_Code.Text,
                Cellphone_Number = cellphone_Number.Text,
                Email = email.Text,
                WorkAddressLine1 = wAddressLine.Text,
                WorkAddressLine2 = wAddressLine2.Text,
                WorkCityOrTown = wCityOrTown.Text,
                WorkPostal_Code = wPostal_Code.Text,

            };

            using (SQLiteConnection connection=new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Models.SettingsModel>();

                var Data = connection.Insert(currentSettings);

            }

        }

        #endregion
    }
}