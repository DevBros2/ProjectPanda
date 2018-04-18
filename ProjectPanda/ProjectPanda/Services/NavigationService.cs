using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ProjectPanda.Services
{
	public class App : Application
	{
		public static Action HideLoginView
		{
			get {
				return new Action (() => App.Current.MainPage.Navigation.PopModalAsync ());
			}
		}

		public async static Task NavigateToProfile(string message)
		{
			await App.Current.MainPage.Navigation.PushAsync (new Profile(message));//this is the main page
		}

		public App ()
		{
			MainPage = new NavigationPage (new MainPage());
		}
	}
}
