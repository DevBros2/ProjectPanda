using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Views;
using ProjectPanda.Pages;
using ProjectPanda.Views.DeliveryViews;
using Xamarin.Forms;
using ProjectPanda.ViewModels.UserViewModels;


namespace ProjectPanda
{
	public partial class App : Application
	{
        public bool IsLoggedIn;

        //The variable for the local database
        public static string DatabaseLocation = string.Empty;



        public App(string dbLocation)
        {
            IsLoggedIn = true;
            InitializeComponent();
            SerapisInit();

            DatabaseLocation = dbLocation;

        }
        
        
        #region App constructor without any construtor arguments 
        public App ()
		{
            IsLoggedIn = true;
			InitializeComponent();

            SerapisInit(); 
        }
        #endregion

        #region Method to test if the user is logged in or not 
        private void SerapisInit()
        {
            if (IsLoggedIn==true)
            {
                 MainPage = new NavigationPage(new MainPage());
               // MainPage = new NavigationPage(new DetailFill());
            }


            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }

            
        }
        #endregion


        #region Start method
        protected override void OnStart ()
		{
            base.OnStart();
            /*First ask for location
             * if [user declines ]
             *      run app normally
             * else
             *  Return location

             */
        }
        #endregion

        #region Sleep method
        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}
        #endregion

        #region Resume method 
        protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        #endregion

    }
}
