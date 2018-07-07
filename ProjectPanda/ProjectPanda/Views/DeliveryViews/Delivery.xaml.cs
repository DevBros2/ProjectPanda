using ProjectPanda.Views.DeliveryViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using System.ComponentModel;
using Xamarin.Forms.Xaml;
using ProjectPanda.ViewModels.DeliveryViewModels;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Delivery : ContentPage
	{

        DeliveryViewModel viewModel; 

        public Delivery ()
		{
			InitializeComponent ();
            viewModel = new DeliveryViewModel();
            BindingContext = viewModel;
            NavigationPage.SetHasNavigationBar(this, true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        #region Order Medicine (brings the chat bot up)

        async private void OrderMedicine(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatBotView());
        }

        #endregion 

    }
      
}