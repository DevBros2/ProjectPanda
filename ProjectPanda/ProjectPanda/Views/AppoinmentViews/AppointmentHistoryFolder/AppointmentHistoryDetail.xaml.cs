using ProjectPanda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews.AppointmentHistoryFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppointmentHistoryDetail : ContentPage
	{

        AppoitmentHistoryViewModel viewModel;

        public AppointmentHistoryDetail (AppoitmentHistoryViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext =this.viewModel= viewModel;
		}

        public AppointmentHistoryDetail()
        {
            InitializeComponent();
            viewModel = new AppoitmentHistoryViewModel();
            BindingContext = viewModel;
        }
    }
}