using ProjectPanda.ViewModels.DeliveryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.DeliveryViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorsPrescription : ContentPage
	{
        DoctorPrescriptionViewModel viewModel;

        public DoctorsPrescription ()
		{
			InitializeComponent ();
            viewModel = new DoctorPrescriptionViewModel();
            BindingContext = viewModel;
		}
	}
}