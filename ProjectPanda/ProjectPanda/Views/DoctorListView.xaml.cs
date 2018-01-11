using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorListView : ContentPage
	{
        DocAvaliableManager manager;

		public DoctorListView ()
		{

			InitializeComponent ();
            manager = DocAvaliableManager.DefaultManager;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshItems();
        }

        //Data methods
        //DoctorListView
        private async Task RefreshItems()
        {
            DoctorList.ItemsSource = await manager.GetDoctorsList(); 
        }


    }
}