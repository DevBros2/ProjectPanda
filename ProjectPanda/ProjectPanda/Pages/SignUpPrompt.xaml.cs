using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private void SignUpGoogle(object sender, EventArgs e)
        {
            //The following code makes instasiates the class
           // Authentication authentication = new Authentication();
            //authentication.GoogeleAuthFunction();
        }

        private void signUpFacebook(object sender, EventArgs e)
        {
            //Authentication authentication = new Authentication();
            //authentication.FacebookAuthFunction();
        }

        private void signUpOutlook(object sender, EventArgs e)
        {
            //Authentication authentication = new Authentication();
            //authentication.MicrosoftAuthFunction();
        }

        private async void backbutton(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Login());
        }

    }
}