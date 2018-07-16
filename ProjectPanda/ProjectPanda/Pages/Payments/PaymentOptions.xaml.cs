using ProjectPanda.ViewModels.PaymentsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages.Payments
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentOptions : ContentPage
	{
        PaymentOptionsViewModel viewModel;

        public PaymentOptions ()
		{
			InitializeComponent ();
            viewModel = new PaymentOptionsViewModel();
            BindingContext = viewModel;
		}
	}
}