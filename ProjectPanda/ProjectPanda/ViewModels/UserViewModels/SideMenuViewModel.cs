using ProjectPanda.Pages;
using ProjectPanda.Pages.AppointmentHistoryFolder;
using ProjectPanda.ViewModels.Base;
using ProjectPanda.Views;
using ProjectPanda.Views.DeliveryViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProjectPanda.Models;

namespace ProjectPanda.ViewModels.UserViewModels
{
    public class SideMenuViewModel:BaseViewModel
    {
        PatientInfo info;
        public ICommand HomeNavigation { get; set; }
        public ICommand PaymentsNavigation { get; set; }
        public ICommand SettingsNavigation { get; set; }
        public ICommand ContactNavigation{ get; set; }
        public ICommand AppointmentNavigation { get; set; }
        public ICommand MedicationNavigation { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand EmergencyCommand { get; set; }

        private string firstName= "Khanyisani";
        private string surname="Buthelezi";


        public string UserName
        {
            get
            {
                return firstName + " " + surname;
            }

        }

        public string UserPicture
        {
            get
            {
                return "userplaceholder.png";
            }
        }

        public SideMenuViewModel()
        {
            HomeNavigation = new Command(async()=>await GoHomePage());
            PaymentsNavigation = new Command(async()=>await GoPaymentsPage());
            SettingsNavigation = new Command(async () => await GoToSettingsPage());
            ContactNavigation = new Command(async () => await GoToContactPage());
            AppointmentNavigation = new Command(async () => await GoToAppointmentHistoryPage());
            MedicationNavigation = new Command(async () => await GoToMedicationHistoryPage());
            LogoutCommand = new Command(async () => await LogOutProtocol());
        }

        #region Side Menu Methods
        private async Task GoHomePage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new TabbedPage1());
        }

        private async Task GoPaymentsPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new PaymentHistory());
        }

        private async Task GoToContactPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SupportPage());
        }

        private async Task GoToAppointmentHistoryPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AppoitnmentHistory());
        }

        private async Task GoToMedicationHistoryPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MainDeliveryPage());
        }

        private async Task GoToSettingsPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Settings());
        }

        private async Task LogOutProtocol()
        {
            var prompt=await App.Current.MainPage.DisplayAlert("You are logging out", "Press Ok to verify", "Ok", "Cancel");


            if (prompt)
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
        }
        #endregion

        
    }
}
