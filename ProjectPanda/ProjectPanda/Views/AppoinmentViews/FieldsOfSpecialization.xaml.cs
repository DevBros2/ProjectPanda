using ProjectPanda.Models;
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
	public partial class FieldsOfSpecialization : ContentPage
	{
        FieldsOfSpecialityViewModel viewModel;

        public FieldsOfSpecialization ()
		{
			InitializeComponent ();
            viewModel = new FieldsOfSpecialityViewModel();
            BindingContext = viewModel;
        }

        private void SpeciltySelected(object sender, SelectedItemChangedEventArgs e)
        {
            //these need to be moved, in mvvm the models should never interact with views
            var item = e.SelectedItem as Specilization;
            if (item == null)
            {
                return;
            }
            else
            {
                string listItem = item.Name.ToString();

                //Before going to the next page, do filtering
                //1. filter by listItem variable

                

                Navigation.PushAsync(new MedicalBuildingView());
            }
        }
    }
}