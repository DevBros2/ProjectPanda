using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Models;

namespace ProjectPanda.Pages.AppointmentHistoryFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppoitnmentHistory : ContentPage
	{
        AppoitmentHistoryViewModel appoitmentViewModel;

        AppoitmentHistoryViewModel AppoitmentHistoryModel;

        public AppoitnmentHistory ()
		{
			InitializeComponent ();

            BindingContext = appoitmentViewModel = new AppoitmentHistoryViewModel();

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

       
    }
}