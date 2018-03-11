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
	public partial class SearchMedicalCondition : ContentPage
	{
		public SearchMedicalCondition ()
		{
			InitializeComponent ();
		}

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //add code for searching for what 
        }
    }
}