using ProjectPanda.ViewModels.SettingsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.SettingsViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppointmentSettings : ContentPage
	{
        //AppointmentSetViewModel viewModel;

        public AppointmentSettings ()
		{
			InitializeComponent ();
           // viewModel = new AppointmentSetViewModel();
           // BindingContext = viewModel;
		}
	}
}