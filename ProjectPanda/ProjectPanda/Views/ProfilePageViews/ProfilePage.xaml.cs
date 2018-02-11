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

namespace ProjectPanda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
           // BloodType.Text = settingsModel.Blood;
           // City.Text = settingsModel.CityOrTown;
            City.Text = Settings.GeneralSettings;
        }



        private async void PrivateInformation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailedUserInfo()); 
        }
    }
}
