using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.DeliveryViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.DeliveryViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelfPrescriptionHistroy : ContentPage
	{

        SelfPrescriptionHistoryViewModel selfPrescriptionModel;

        public SelfPrescriptionHistroy ()
		{
			InitializeComponent ();

            BindingContext = selfPrescriptionModel = new SelfPrescriptionHistoryViewModel();

        }




        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }


    }
}