using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Views;
using ProjectPanda.Pages;
using ProjectPanda.Views.DeliveryViews;
using Xamarin.Forms;

namespace ProjectPanda
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //InitApp();
//
            //MainPage = new ProjectPanda.MainPage();
           // MainPage = new NavigationPage(new Pages.SplashPage());
            MainPage = new NavigationPage(new DoctorListView());
        }

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

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
