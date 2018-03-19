using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using ProjectPanda.Pages;
using ProjectPanda.ViewModels.UserViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Helpers;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
        //private LoginPageViewModel _viewModel;
        public LoginPage ()
		{
           // BindingContext = _viewModel = vm;

            InitializeComponent ();
            //disables NavBar
           NavigationPage.SetHasNavigationBar(this, false);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           // var LoginPage = new NavigationPage(new LoginPage())
           // {
           //     BarBackgroundColor = Color.FromHex("#60a83a"),
           //     BarTextColor = Color.White,
           // };

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            #region Huge comment section
            // _viewModel.SignIn();

            /*
             
                    if(EmailAddress && Password && (isAuthenticated==true) == those in the databse )    {Navigation.PushAsync(new MainProfilePage());}
             
             */
            // await Navigation.PushModalAsync(new ProjectPanda.Pages.MainPage());
            // Navigation.InsertPageBefore(new LoginPage(), new MainPage());

            // await Navigation.PushAsync(new ProjectPanda.Pages.DetailFill());
            #endregion
        }

         async void prompt(object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new ProjectPanda.Pages.MainPage());
            // Navigation.InsertPageBefore(new LoginPage(), new MainPage());
            
            await Navigation.PushAsync(new SignUpPrompt());
        }


         async void ContactUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupportPage());
        }


    }
}
