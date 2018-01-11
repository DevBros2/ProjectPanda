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

        //this is for the switch
        private void DependencyPresent(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
           
        }




        async Task AddDetails(UserRegistration userregistration )
        {
            await manager.InsertUsers(userregistration);
           
        }

        public async void NextDetailfillPage(object sender, EventArgs e)
        {
            var users = new UserRegistration {
                FirstName = first_name.Text,
                Surname = surname.Text,
                EmailAddress= email_address.Text,
                Cellphone= cellphoneNum.Text,
              
            };
            await AddDetails(users);

            first_name.Text = string.Empty;
            first_name.Unfocus();

            surname.Text = string.Empty;
            surname.Unfocus();

            email_address.Text = string.Empty;
            email_address.Unfocus();

            cellphoneNum.Text = string.Empty;
            cellphoneNum.Unfocus();

         //Gonna add them later cause well they are a diffrent data type for some reason
            
           //  bloodPicker.Text = string.Empty;
           //  bloodPicker.Unfocus();

         //   medicalAidPicker.Text = string.Empty;
         //   medicalAidPicker.Unfocus();




            await Navigation.PushAsync(new DetailFillPageChronic());
        }
    }
}
