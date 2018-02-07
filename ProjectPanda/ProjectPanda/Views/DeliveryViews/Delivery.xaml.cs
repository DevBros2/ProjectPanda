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

        public int _heightRequest;

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




        private void DocPrescription_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
   
            _heightRequest = 420;

           // DocPrescription.HeightRequest = (_heightRequest);

           
        }


        #region The items tapped method
        private void MedList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

          //  var selectedItem = (ViewCell)sender;

         //   if(selectedItem != null) { selectedItem.View.BackgroundColor = Color.Blue; }


        }

        #endregion

       

        #region The code for the doctors prescription

        private void MedList_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            if(e.Item != null)
            {
             //   foreach (var Item in )
               // {

                //}
            }

            //adding a item list empty picture or animation makes it look better
            else if(e.Item==null)
            {
                DocPrescription.IsVisible = false;
            }

        }

        #endregion


        #region The button to make medical orders 
        async private void MedDeliveryButton_Clicked(object sender, EventArgs e)
        {
            //This needs to use a diffrent navigfation method
           await Navigation.PushAsync(new Views.PopUpPages.EditorPopUp());
        }
        #endregion
    }
}