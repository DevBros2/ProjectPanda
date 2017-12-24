using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Views;

using Xamarin.Forms;

namespace ProjectPanda
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //InitApp();

            //MainPage = new ProjectPanda.MainPage();
            //var MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new LoginPage())
            {
                //BarBackgroundColor = Color.FromHex("#229122"),
                BarBackgroundColor = Color.LimeGreen,
                BarTextColor = Color.White,
            };

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
