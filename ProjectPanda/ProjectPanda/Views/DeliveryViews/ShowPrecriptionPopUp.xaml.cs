using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.ViewModels;
namespace ProjectPanda.Views.DeliveryViews.DeliveryPopUps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowPrecriptionPopUp : ContentPage
	{

        PrescribedMedicationListView precribedMedsModel;
        PrescribedMedicationListView prescribedMedsModelList;

        public ShowPrecriptionPopUp ()
		{
			InitializeComponent ();


            BindingContext = precribedMedsModel = new PrescribedMedicationListView();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}