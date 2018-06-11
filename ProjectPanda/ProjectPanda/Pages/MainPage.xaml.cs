using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Views;
using ProjectPanda.ViewModels.UserViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {

        SideMenuViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new TabbedPage1());
            NavigationPage.SetHasNavigationBar(this, true);

            viewModel = new SideMenuViewModel();
            BindingContext = viewModel;
     
        }

        #region Sos emergency

        private void SosEmergency(object sender, EventArgs e)
        {
            //calls the emergency Api Of the device for help
        }
        #endregion

        


    }
}