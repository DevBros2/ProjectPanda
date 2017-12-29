using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Models;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardView : ContentPage
	{
        CardDataViewModel viewModel;
        public CardDataModel CardDataModel;
        public CardView ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new CardDataViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.dataList.Count == 0)
                viewModel.LoadDataCommand.Execute(null);
        }

        async void MedicalListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var cardata = e.SelectedItem as CardDataModel;
            if (cardata == null)
                return;
            await Navigation.PushAsync(new DoctorListView());
        }
    }
}