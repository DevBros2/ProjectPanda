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
        private void GoogleSignIn(object sender, EventArgs e)
        {
            //The following code makes instasiates the class
           // Authentication authentication = new Authentication();
            //authentication.GoogeleAuthFunction();
        }

        private void FacebookSignIn(object sender, EventArgs e)
        {
            //Authentication authentication = new Authentication();
            //authentication.FacebookAuthFunction();
        }

        private void OutlookSignIn(object sender, EventArgs e)
        {
            //Authentication authentication = new Authentication();
            //authentication.MicrosoftAuthFunction();
        }

        private async void OurSignIn(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Login());
        }

    }
}