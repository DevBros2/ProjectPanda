using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using ProjectPanda.Models;
using ProjectPanda.Views.AppoinmentViews.AppointmentHistoryFolder;
//using ProjectPanda.Models;

namespace ProjectPanda.Pages.AppointmentHistoryFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppoitnmentHistory : ContentPage
	{
        AppoitmentHistoryViewModel appoitmentViewModel;

        public AppoitnmentHistory ()
		{
			InitializeComponent ();
            appoitmentViewModel = new AppoitmentHistoryViewModel();
            BindingContext = appoitmentViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void AppointmentHistory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AppoitmentHistoryModel;
            if (item == null) return;
            await Navigation.PushAsync(new AppointmentHistoryDetail(new AppoitmentHistoryViewModel(item)));
         
        }
    }
}