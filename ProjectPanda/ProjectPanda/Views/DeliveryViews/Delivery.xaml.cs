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

using ProjectPanda.Views.DeliveryViews.DeliveryPopUps;

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

        #region Self prescribed medication history
        private async void OrderHistorySelfPrecribedMeds(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelfPrescriptionHistroy());
        }
        #endregion


        #region The button to make medical orders 
        async private void DocPrescriptionHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrescriptionHistory());
        }
        #endregion

        #region Order Medicine (brings the chat bot up)

        async private void OrderMedicine(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatBotView());
        }

        #endregion 

        #region The button for brining up the pop up for doctor prescription

        async private void ShowDocPrecription(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowPrecriptionPopUp());
        }

       
    }
          #endregion
}