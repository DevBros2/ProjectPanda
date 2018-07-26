using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages.Payments
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentOptions : ContentPage
	{
		public PaymentOptions ()
		{
			InitializeComponent ();
		}

        public string CreateToken(string cardNumber, int cardExpMonth, int cardExpYear, string cardCVC)
        {
            StripeConfiguration.SetApiKey("pltestxxxxxxx");//do not put our secrtet key in the mobile app

            var token = new StripeTokenCreateOptions()
            {
                Card = new StripeCreditCardOptions()
                {
                    Number = cardNumber,
                    ExpirationYear = cardExpYear,//might have to convert this to a string later ons
                    ExpirationMonth = cardExpMonth,
                    Cvc = cardCVC

                }
            };
            var tokenSerivce = new StripeTokenService();
            StripeToken stripeToken = tokenSerivce.Create(token); 
            return stripeToken.Id;   
        }
        /// <summary>

        /// Do not log any Https calls, since it can be retrived in crash reports
        /// clear all fields after navigating away from the page. OnDisappearing();

        /// </summary>
        /// the next code shouldnt be in this file, but because of time ill leave it here for now

        HttpClient client = new HttpClient();
       
    }
}