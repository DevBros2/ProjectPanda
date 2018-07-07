using ProjectPanda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PracticeListView : ContentPage
	{
        MedicalBuildingViewModel viewModel;
        public PracticeListView ()
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