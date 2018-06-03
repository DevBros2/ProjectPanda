using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectPanda.Helpers;
using ProjectPanda.Models;
using ProjectPanda.ViewModels.UserViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        ProfilePageViewModel viewModel;

        public ProfilePage()
        {
            InitializeComponent();
            viewModel = new ProfilePageViewModel();
            BindingContext = viewModel;
        }

    }
}
