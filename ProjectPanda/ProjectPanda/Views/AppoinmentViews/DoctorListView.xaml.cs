using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Services;
using ProjectPanda.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorListView : ContentPage
	{
        DoctorListViewModel viewmodel;
        public DocAvaliable DocAvaliable;

		public DoctorListView ()
		{
			InitializeComponent ();
           // DoctorList.On<Android>().SetIsFastScrollEnable(true);
           
            BindingContext = viewmodel = new DoctorListViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //await RefreshItems();
        }


        private void DoctorList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = viewmodel;


            var doctors = e.Item as DocAvaliable;
            vm.HideOrShowProfile(doctors);
        }

        private async void DoctorList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DocAvaliable;
            if (item == null)
                return;

           await  Navigation.PushAsync(new MedicalBuildingView());
            DoctorList.SelectedItem = null;
        }
    }
    
}