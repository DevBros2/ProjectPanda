using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Services;
using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFill : ContentPage
    {
        UserRegistrationManager manager;
        public DetailFill()
        {
            InitializeComponent();
            manager = UserRegistrationManager.DefaultManager;
        }

       
        async Task AddDetails(UserRegistration userregistration )
        {
            await manager.InsertUsers(userregistration);
           
        }

        public async void NextDetailfillPage(object sender, EventArgs e)
        {
            var users = new UserRegistration { FirstName = first_name.Text };
            await AddDetails(users);

            first_name.Text = string.Empty;
            first_name.Unfocus();

            await Navigation.PushAsync(new DetailFillPageChronic());
        }
    }
}
