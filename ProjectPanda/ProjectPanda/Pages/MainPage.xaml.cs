using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Views;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
           
        }
        #region Event handlers for the side menu
        private void Menu_btn2_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Settings());

            IsPresented = false;



        }

        private void Menu_btn4_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SupportPage());
            IsPresented = false;
        }

        private void Menu_btn3_Clicked(object sender, EventArgs e)
        {
            // This button is for payment history
            Detail = new NavigationPage(new PaymentHistory());
            IsPresented = false;
        }




        //   void Button_Clicked(object sender, EventArgs e)
        //    => new NavigationPage();//doctorlist

        private void AppointmentHistory(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProjectPanda.Pages.AppointmentHistoryFolder.AppoitnmentHistory());
            IsPresented = false;
        }

        #region define the display pop up

        #endregion

        async private void Logout_Button_Clicked(object sender, EventArgs e)
        {

            var result = await DisplayAlert("You are logging out", "Press Ok to verify", "Ok", "Cancel");

            if (result)
            {
                //need to put a log out protocol that deletes the users information on that device 
                Navigation.PushModalAsync(new LoginPage());
               
            }

            //supposed to reset the navigation stack
            //Navigation.NavigationStack
        }






        #endregion

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
             
        }
    }
}