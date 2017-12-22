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

			//MainPage = new ProjectPanda.MainPage();
            MainPage = new NavigationPage(new LoginPage());

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
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
