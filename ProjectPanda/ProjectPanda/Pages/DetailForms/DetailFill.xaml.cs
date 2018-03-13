using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Services;
using Xamarin.Forms;
using System.ComponentModel;
using ProjectPanda.Models.DetailUserModel;
using Xamarin.Forms.Internals;

namespace ProjectPanda.Pages
{
    public partial class DetailFill : ContentPage
    {

        public String GlobalString;
        public bool hasDependencies;
       

        UserRegistrationManager manager;
        public DetailFill()
        {
            InitializeComponent();
            manager = UserRegistrationManager.DefaultManager;



            /*
            
                DetailedUserModel detailedUser = new DetailedUserModel();
                    userDetails.BindingContext = detailedUser;

            userDetails.Root.Remove(dependencyViewcell);

              detailedUser.PropertyChanging += (sender, args) =>
              {
                  if (detailedUser.hasDependencies && userDetails.Root.IndexOf(dependencyViewcell) == -1)
                  {
                      userDetails.Root.Add(dependencyViewcell);
                  }
                  if(!userDetails.hasDependencies && userDetails.Root.IndexOf(dependencyViewcell)!=-1)
                  {
                      userDetails.Root.Remove(detailedUser);
                  }
              };
           */
        }

        //this is for the switch
        #region



        #endregion

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
            //first_name.Unfocus();

            surname.Text = string.Empty;
           // surname.Unfocus();

            email_address.Text = string.Empty;
           // email_address.Unfocus();

            cellphoneNum.Text = string.Empty;
          //  cellphoneNum.Unfocus();

            //Gonna add them later cause well they are a diffrent data type for some reason

            //   medicalAidPicker.Text = string.Empty;
            //   medicalAidPicker.Unfocus();

            await Navigation.PushAsync(new DetailFillPageChronic());
        }

        //Rather use the messaging center then send them at the end
        async Task AddDetails(UserRegistration userregistration)
        {
            await manager.InsertUsers(userregistration);
        }

    }
}
