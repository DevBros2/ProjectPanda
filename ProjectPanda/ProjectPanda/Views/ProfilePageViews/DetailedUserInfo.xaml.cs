using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailedUserInfo : ContentPage
	{

   

        public DetailedUserInfo ()
		{
			InitializeComponent ();

           // BindingContext = listOfDetails = new DetailedUserViewModel;

        }

        private void allergyList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AllergiesDetailList());
        }


        private void medciationList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MedicationDetailList());
        }

        private void chronicDiseaseList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChronicDiseaseList());
        }

    }
}