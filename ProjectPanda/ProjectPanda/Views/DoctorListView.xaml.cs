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
        // DocAvaliableManager manager;
        DoctorListViewModel viewmodel;
		public DoctorListView ()
		{

			InitializeComponent ();
            //manager = DocAvaliableManager.DefaultManager;
            BindingContext = viewmodel = new DoctorListViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //await RefreshItems();
        }

         void Make_Button_Visable(object sender, ItemTappedEventArgs e)
        {
            var vm = viewmodel;


            var doctors = e.Item as DocAvaliable;
            vm.HideOrShowProfile(doctors);
        } 

        //Data methods
        //DoctorListView
        //private async Task RefreshItems()
        //{
        //    DoctorList.ItemsSource = await manager.GetDoctorsList(); 
        // }

    }
}