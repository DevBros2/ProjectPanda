using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Delivery : ContentPage
	{
        public Delivery delivery { get; set; }

        public Delivery ()
		{
			InitializeComponent ();

            delivery = new Delivery
            {

            };
            BindingContext = this;
        }
        private async Task Delivery_Button_Clicked(object sender, EventArgs e)

        => await Navigation.PushAsync(new PaymentPage());
    }
}