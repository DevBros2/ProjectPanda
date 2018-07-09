using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
//using ProjectPanda.Models;

namespace ProjectPanda.Pages.AppointmentHistoryFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppoitnmentHistory : ContentPage
	{
        AppoitmentHistoryViewModel appoitmentViewModel;

        AppoitmentHistoryViewModel AppoitmentHistoryModel;

        public Command RemoveAppointmentLog { get; }

        public AppoitnmentHistory ()
		{
			InitializeComponent ();

            BindingContext = appoitmentViewModel = new AppoitmentHistoryViewModel();

           
        }


       

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        private void OnMore(object sender, EventArgs e)
        {
            var more = ((MenuItem)sender);
            DisplayAlert("Hide Log", more.CommandParameter + "Cancel", "OK");
        }
       
        private void OnDelete(object sender, EventArgs e)
        {
            var deletion = ((MenuItem)sender);
            DisplayAlert("Delete Appointment Log", deletion.CommandParameter + "Cancel", "OK");
        }

    }
}