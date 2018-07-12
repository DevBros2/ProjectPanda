using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Services;
using ProjectPanda.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Views;
using ProjectPanda.ViewModels.UserViewModels;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPrompt : ContentPage
	{

        SignUpPromptViewModel viewModel;

        public SignUpPrompt ()
		{
            InitializeComponent ();
            viewModel = new SignUpPromptViewModel();
            BindingContext = viewModel;
        }

          private void GoogleSignIn(object sender, EventArgs e)
        {
            //The following code makes instasiates the class
            AuthenticationGoogle google = new AuthenticationGoogle();
            google.OnLoginClicked();

        }

        private void FacebookSignIn(object sender, EventArgs e)
        {
            AuthenticationFacebook facebook = new AuthenticationFacebook();
            facebook.OnLoginClicked();
            
        }

        private void OutlookSignIn(object sender, EventArgs e)
        {
            AuthenticationMicrosoft microsoft = new AuthenticationMicrosoft();
            microsoft.OnLoginClicked();
           
        }

        private async void OurSignIn(object sender, EventArgs e)
        {
            
              //await Navigation.PushAsync(new Pages.MainPage());
              Navigation.InsertPageBefore(new LoginPage(), Navigation.NavigationStack[0]);
              await Navigation.PopToRootAsync();
              Navigation.RemovePage(new LoginPage());
              Navigation.RemovePage(new SignUpPrompt());
        }

    }
}