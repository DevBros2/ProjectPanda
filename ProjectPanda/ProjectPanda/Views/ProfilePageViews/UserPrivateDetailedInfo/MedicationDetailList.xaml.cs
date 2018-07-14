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
        

        public MedicationDetailList ()
		{
			InitializeComponent ();
            medication = new MedicationDetailListViewModel();
            BindingContext = medication;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
          //  medication.ShowSearchElement = false;
        }

    }
}