using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages.DetailForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailFillAllergies : ContentPage
	{
		public DetailFillAllergies ()
		{
			InitializeComponent ();
		}



        private void showValues_Toggled(object sender, ToggledEventArgs e)
        {
            //this toggle switch displayes or hides the search bar icon
            if (e.Value == false)
            {
                 allergySearch.IsVisible = false;
            }
            else
            {
                 allergySearch.IsVisible = true;
            }
        }



        async void MainProfilePageNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DetailFillPageMeds());
        }


    }
}