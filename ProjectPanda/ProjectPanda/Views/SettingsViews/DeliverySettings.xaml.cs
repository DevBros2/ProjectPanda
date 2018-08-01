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
	public partial class DeliverySettings : ContentPage
	{
        //DeliverySetViewModel viewModel;

        public DeliverySettings ()
		{
			InitializeComponent ();
           // viewModel = new DeliverySetViewModel();
           // BindingContext = viewModel;
            
        }
	}
}