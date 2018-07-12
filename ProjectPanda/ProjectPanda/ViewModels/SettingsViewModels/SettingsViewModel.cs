using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.ComponentModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using ProjectPanda.Views.SettingsViews;

namespace ProjectPanda.ViewModels.SettingsViewModels
{
    public class SettingsViewModel
    {
        public Command PersonalPage { get; set; }
        public Command DeliveryPage { get; set; }
        public Command AppointmentPage { get; set; }

        public SettingsViewModel()
        {
            PersonalPage = new Command(async () => await NavPersonal());
            DeliveryPage = new Command(async () => await NavDelivery());
            AppointmentPage = new Command(async () => await NavCalendar());
        }

        #region Navigation Methods
        private async Task NavPersonal()
        {
            await App.Current.MainPage.Navigation.PushAsync(new PersonalSettings());
        }

        private async Task NavCalendar()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AppointmentSettings());
        }

        private async Task NavDelivery()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DeliverySettings());
        }

        #endregion
    }
}
