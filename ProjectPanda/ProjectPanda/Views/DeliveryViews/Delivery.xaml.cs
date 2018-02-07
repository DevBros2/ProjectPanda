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
using ProjectPanda.Views.PopUpPages;


namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Delivery : ContentPage
	{

        PrescribedMedicationListView prescribedModel;
        PrescribedMedicationListView prescribeModelList;

     

        public Delivery ()
		{
			InitializeComponent ();

            BindingContext = prescribedModel = new PrescribedMedicationListView();


            NavigationPage.SetHasNavigationBar(this, true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        private async void SelfMed_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatBotView());
        }



     

        #region The button to make medical orders 
        async private void MedDeliveryButton_Clicked(object sender, EventArgs e)
        {
            //This needs to use a diffrent navigfation method
           await Navigation.PushAsync(new Views.PopUpPages.EditorPopUp());
        }
        #endregion
    }
}