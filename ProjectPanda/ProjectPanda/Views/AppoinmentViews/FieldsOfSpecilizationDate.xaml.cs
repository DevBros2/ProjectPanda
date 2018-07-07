using ProjectPanda.ViewModels.AppointmentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FieldsOfSpecilizationDate : ContentPage
	{
        FieldsOfSpecialityViewModel viewModel;

        public FieldsOfSpecilizationDate ()
		{
			InitializeComponent ();
            viewModel = new FieldsOfSpecialityViewModel();
            BindingContext = viewModel;
		}
	}
}