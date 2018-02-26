using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using ProjectPanda.ViewModels.AppointmentViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicalBuildingMoreInfo : ContentPage
	{
        DoctorsAtPracticeViewModel viewModel;

        public MedicalBuildingMoreInfo ()
		{
			InitializeComponent ();


            BindingContext = viewModel = new DoctorsAtPracticeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}