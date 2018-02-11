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
using ProjectPanda.Views.AppoinmentViews;
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

        #region Navigation  to doctors at the practice
        private async void MedicalBuilding_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MedicalBuildingModel;
            if (item == null)
                return;

           await Navigation.PushAsync(new AppointmentView());

           MedicalBuilding.SelectedItem = null;
        }
        #endregion

        #region More information on that practice
        private void MoreInformation(object sender, EventArgs e)
        {
            //for now using the navigation push method cause I asked charlin to help me with the pop ups

            //This event handler gives more information than the the standard view card 

            Navigation.PushAsync(new MedicalBuildingMoreInfo());
                

        }

        #endregion


    }
}