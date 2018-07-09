using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.AppointmentViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicalBuildingMoreInfo : ContentPage
	{
        MedicalBuildingMoreInfoViewModel viewModel;

        public MedicalBuildingMoreInfo ()
		{
			InitializeComponent();

            BindingContext = viewModel = new MedicalBuildingMoreInfoViewModel();
        }

       

    }
}