using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.ViewModels.AppointmentViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.AppoinmentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProblemEntryPage : ContentPage
	{


        public ProblemEntryPage ()
		{
			InitializeComponent ();
		}


        async private void NextPageConfirmation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmationPage());
        }



        #region Send the paragraph to the next page
        async public void SendParagraphToNextPage(object sender, EventArgs e)
        {
            //On completed event handler

        }
        #endregion

      
      

      
    }
}