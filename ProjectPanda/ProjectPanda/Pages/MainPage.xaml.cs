using System;
using System.Collections.Generic;
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
		public MainPage ()
		{
			InitializeComponent ();
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

        private void Logout_Button_Clicked(object sender, EventArgs e)
        {
            //code that will allow for logging out.
            Detail =  new NavigationPage(new LoginPage());

            //need to add a pop up dialog rather than a navigation

        }


        #endregion


    }
}