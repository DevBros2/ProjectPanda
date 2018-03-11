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
        ChronicDiseaseListModel chronicDiseaseModel;

        public ChronicDiseaseList ()
		{
			InitializeComponent ();

            BindingContext = chronicModel = new ChronicDiseaseListViewModel();
		}


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchMedicalCondition()); 
        }
    }
}