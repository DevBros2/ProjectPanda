using ProjectPanda.Views.DeliveryViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Delivery : ContentPage
	{
		public Delivery ()
		{
			InitializeComponent ();


            NavigationPage.SetHasNavigationBar(this, true);
        }

        private async void SelfMed_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatBotView());
        }


        /*
              if(the list is empty in the frame){
                  MedDeliveryButton.IsVisble=false;

              }
              
            else{
           
                    MedDeliveryButton.IsVisible=true;
                 }

        */


    }
}