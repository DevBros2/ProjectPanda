using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectPanda.Models.DetailUserModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.ViewModels.DetailUserViewModels;

namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChronicDiseaseList : ContentPage
	{

        ChronicDiseaseListViewModel chronicModel;

        public ChronicDiseaseList()
		{
			InitializeComponent ();
            chronicModel = new ChronicDiseaseListViewModel();
            BindingContext = chronicModel;

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

    }
}