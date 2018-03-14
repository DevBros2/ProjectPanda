using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchMedicalConditionChronicDisease : ContentPage
	{
		public SearchMedicalConditionChronicDisease ()
		{
			InitializeComponent ();
		}

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //search the Allergies text file with all the allergies 
        }

    }
}