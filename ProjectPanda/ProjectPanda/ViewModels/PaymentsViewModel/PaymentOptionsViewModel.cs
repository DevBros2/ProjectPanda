using ProjectPanda.Models.PaymentsModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectPanda.ViewModels.PaymentsViewModel
{
     public class PaymentOptionsViewModel
    {

        public ObservableCollection<PaymentOptionsModel> Options { get; set; } 

        public PaymentOptionsViewModel()
        {
            GeneratePaymentOptions();
        }

        private void GeneratePaymentOptions()
        {
            Options = new ObservableCollection<PaymentOptionsModel>
            {
               new PaymentOptionsModel{ PaymentMethodIcon="CreditcardIcon2.png", PaymentMethodName="Credit or debit card"},
               //new PaymentOptionsModel{PaymentMethodIcon="Discovery.png", PaymentMethodName="Discovery"}
            };
        }

    }
}
