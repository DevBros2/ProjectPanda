using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using ProjectPanda.Models;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicalBuildingView : ContentPage
	{
        MedicalBuildingViewModel viewModel;
        

        public MedicalBuildingView ()
		{
			InitializeComponent ();
            
            
            BindingContext = viewModel = new MedicalBuildingViewModel();
           // BindingContext = viewModel = new DoctorListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            

        }

        private async void MedicalBuilding_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MedicalBuildingViewModel;
            if (item == null)
                return;

           await Navigation.PushAsync(new DoctorListView());

            MedicalBuilding.SelectedItem = null;
        }

        private void MoreInformation(object sender, EventArgs e)
        {
            //The pop up with graphs and more information about that practice 
        }

       

    }
}