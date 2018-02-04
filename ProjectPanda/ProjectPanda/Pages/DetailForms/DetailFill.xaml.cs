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

        public String GlobalString;

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

        #region medical aid event handler
        //this is for the medical aid text
         void medicalAidPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker medicalAidPicker = (Picker)sender;
            int selectedIndex = medicalAidPicker.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            string selectedItem = medicalAidPicker.Items[selectedIndex];



        }
        #endregion


        #region blood picker event handler
        //the blood picker text
        private void bloodPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker bloodPicker = (Picker)sender;

        }
        #endregion


       

        public async void NextDetailfillPage(object sender, EventArgs e)
        {
            //All this code must be pushed to the ViewModel

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

            //   medicalAidPicker.Text = string.Empty;
            //   medicalAidPicker.Unfocus();

            await Navigation.PushAsync(new DetailFillPageChronic());
        }

        async Task AddDetails(UserRegistration userregistration)
        {
            await manager.InsertUsers(userregistration);

        }

    }
}
