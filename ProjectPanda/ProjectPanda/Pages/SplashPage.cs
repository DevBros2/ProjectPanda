using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Views;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
	public class SplashPage : ContentPage
	{
        Image splashImage;
		public SplashPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "MainLogo.jpg",
                WidthRequest = 100,
                HeightRequest = 100
            };
                AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional); 
                AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.White;
            this.Content = sub;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 1000); //Time-consuming processes such as initialization
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new LoginPage());    //After loading  MainPage it gets Navigated to our new Page
        }
    }
}