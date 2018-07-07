using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentHistory : ContentPage
	{
		public PaymentHistory ()
		{
			InitializeComponent ();
            //removes the second Navbar 
           // NavigationPage.SetHasNavigationBar(this, false);
        }

        #region Pick a payment option
        private void PickPaymentOption(object sender, EventArgs e)
        {
            //the code to go to the paymant option selection and updating credt/debit information

        }
        #endregion

        #region View the payment history
        private void ViewPaymentHistory(object sender, EventArgs e)
        {
            //The code for the vieng for the payment history
        }
        #endregion

        #region Manage the subscriptions
        private void ManageSubscription(object sender, EventArgs e)
        {
            //The code for managing the subscriptions for chronic diseases 
        }
        #endregion
    }

}