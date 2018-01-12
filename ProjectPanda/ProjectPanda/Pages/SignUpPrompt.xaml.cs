using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Services;
using ProjectPanda.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPrompt : ContentPage
	{
		public SignUpPrompt ()
		{
			InitializeComponent ();
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
            //await Navigation.PushAsync(new MainPage());
            await Navigation.PushAsync(new DetailFill());
        }

    }
}