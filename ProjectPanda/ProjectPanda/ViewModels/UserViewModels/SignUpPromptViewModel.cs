using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.UserViewModels
{
    public class SignUpPromptViewModel
    {

        public SignUpPromptViewModel()
        {
            CustomEmail =new Command(async()=> await MainApp());
        }

        #region Properties for logging in

        //get from database
        private string email;
        private string password;

        public Command GoogleLogin { get; set; }
        public Command FacebookLogin { get; set; }
        public Command MicrosoftLogin { get; set; }
        public Command CustomEmail { get; set; }

        public string Email
        {
            get
            {
                return email;
            }

        }
        public string Password
        {
            get
            {
                return password;
            }
        }
        #endregion

        #region Methods 
        
        public bool VerifyLogin()
        {
            if(Email==email && Password==password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public async Task GoogleLoginPropmt()
        {

        }

        //for now to move to the other page
        public async Task MainApp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.MainPage());
        }

        #endregion
    }
}
