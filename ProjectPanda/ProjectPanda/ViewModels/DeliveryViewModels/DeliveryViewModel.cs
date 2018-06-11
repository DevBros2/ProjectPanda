using ProjectPanda.ViewModels.Base;
using ProjectPanda.Views.DeliveryViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
    public class DeliveryViewModel:BaseViewModel
    {
        public Command NavigateToPrescription { get; set; }
        public Command NavigateToSelfPresription { get; set; }

        public DeliveryViewModel()
        {
            NavigateToPrescription = new Command(async () => await ShowPrescription());
            NavigateToSelfPresription = new Command(async () => await GoToChatBot());
        }

        #region Methods
        private async Task ShowPrescription()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DoctorsPrescription());
        } 
        
        
        private async Task GoToChatBot()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ChatBotView());
        }

        #endregion
    }
}
