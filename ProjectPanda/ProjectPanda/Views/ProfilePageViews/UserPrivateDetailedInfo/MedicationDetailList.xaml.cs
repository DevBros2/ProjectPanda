using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.DetailUserViewModels;
using ProjectPanda.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicationDetailList : ContentPage
	{

        MedicationDetailListViewModel medication;
        MedicationDetailListViewModel MedicationBuildingModel;

        public MedicationDetailList ()
		{
			InitializeComponent ();


            BindingContext = medication = new MedicationDetailListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }




    }
}