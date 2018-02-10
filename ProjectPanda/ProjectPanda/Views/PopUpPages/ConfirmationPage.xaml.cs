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
	public partial class ConfirmationPage : ContentPage
	{
		public ConfirmationPage ()
		{
			InitializeComponent ();
		}


    
        async private void FinalConfirmation(object sender, EventArgs e)
        {
            //This sends all the booking information to the cloud 
            //Change the page to display the appointment page
           
        }
    }
}