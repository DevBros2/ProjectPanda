using ProjectPanda.Models;
using ProjectPanda.Pages.Payments;
using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.PaymentsViewModel
{
     public class PaymentViewModel:BaseViewModel
    {
        public ObservableCollection<PaymentModel> PaymentMethods { get; set; }

        public Command AddPayment { get; set; }

        public PaymentViewModel()
        {
            GeneratePaymentMethods();
            AddPayment = new Command(async()=> await NavigateOptions());
        }

        private void GeneratePaymentMethods()
        {
            PaymentMethods = new ObservableCollection<PaymentModel>()
            {
                new PaymentModel{ CardNumber="234453426553457567", CVV="233", CardIcon="mastercardIcon.png", ExpDate="23/06"}
            };
        }


        private async Task NavigateOptions()
        {
           await App.Current.MainPage.Navigation.PushAsync(new PaymentOptions());
        }

    }
}
