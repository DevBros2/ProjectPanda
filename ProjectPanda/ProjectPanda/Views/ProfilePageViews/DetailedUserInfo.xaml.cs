using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo;
using ProjectPanda.ViewModels.DetailUserViewModels;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailedUserInfo : ContentPage
	{

        DetailedUserViewModel viewModel; 

        public DetailedUserInfo ()
		{
			InitializeComponent ();

            viewModel = new DetailedUserViewModel();
            BindingContext = viewModel;
            
        }
 
    }
}