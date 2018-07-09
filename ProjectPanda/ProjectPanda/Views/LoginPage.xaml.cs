using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using ProjectPanda.Pages;
using ProjectPanda.ViewModels.UserViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
         LoginPageViewModel viewModel;
        public LoginPage ()
		{
           

            InitializeComponent ();
            //disables NavBar
            NavigationPage.SetHasNavigationBar(this, false);
            viewModel = new LoginPageViewModel();
            BindingContext = viewModel;
        }


    }
}
