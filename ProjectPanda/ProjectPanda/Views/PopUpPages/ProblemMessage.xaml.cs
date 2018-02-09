using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.PopUpPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProblemMessage : ContentPage
	{
		public ProblemMessage ()
		{
			InitializeComponent ();
		}


        #region Go to the next page with confirmation
         async private void NextPageConfirmation(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ConfirmationPage());
        }
        #endregion


        #region Go back to the previous page

     

        #endregion
    }
}