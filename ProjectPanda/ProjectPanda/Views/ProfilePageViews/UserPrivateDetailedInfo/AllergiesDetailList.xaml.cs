using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.DetailUserViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Models.DetailUserModel;

namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllergiesDetailList : ContentPage
	{

        AllergiesDetailListViewModel allergiesModel;
        AllergiesDetailListViewModel allergiesModelList;

        public AllergiesDetailList ()
		{
			InitializeComponent ();

            BindingContext = allergiesModel = new AllergiesDetailListViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new SearchMedicalCondition());
        }

     
      
    }
}