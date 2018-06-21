using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Views;
using ProjectPanda.Pages;
using ProjectPanda.Views.DeliveryViews;
using Xamarin.Forms;
using ProjectPanda.ViewModels.UserViewModels;
using ProjectPanda.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace ProjectPanda
{
	public partial class App : Application
	{
        

        //The variable for the local database
        public static string DatabaseLocation = string.Empty;

        public static MedicalBuildingModel practice = new MedicalBuildingModel();

        public static DocAvaliable doctor = new DocAvaliable();

        public static MobileServiceClient client = new MobileServiceClient("https://projectpanda.azurewebsites.net");

        public App(string dbLocation)
        {
            
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = dbLocation;

        }
        
        
        #region App constructor without any construtor arguments 
        public App ()
		{
			InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
           
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
