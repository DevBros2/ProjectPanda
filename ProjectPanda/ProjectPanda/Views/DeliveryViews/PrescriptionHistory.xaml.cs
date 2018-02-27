using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.ViewModels.DeliveryViewModels;

namespace ProjectPanda.Views.DeliveryViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrescriptionHistory : ContentPage
	{
        PrescriptionHistroyViewModel prescriptionModel;
        

        public PrescriptionHistory ()
		{
			InitializeComponent ();

            BindingContext = prescriptionModel = new PrescriptionHistroyViewModel();

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