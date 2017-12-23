using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;

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

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}