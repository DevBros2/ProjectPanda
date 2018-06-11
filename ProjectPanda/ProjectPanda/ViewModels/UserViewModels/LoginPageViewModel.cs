using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProjectPanda.ViewModels.Base;
using System.Windows.Input;
using System.Threading.Tasks;
using ProjectPanda.Pages;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.UserViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }
        public ICommand HelpCommand { get; set; }


        public LoginPageViewModel()
        {
            SignInRequired = true;
            LoginCommand = new Command(async () => await Login());
        }

        #region Properties
        private bool _signInRequired;
        public bool SignInRequired
        {
            get
            {
                return _signInRequired;
            }
            private set
            {
                _signInRequired = value;
                // OnPropertyChanged("SignInRequired");
            }
        }
        #endregion

        #region Methods
        public void SignIn()
        {
            SignInRequired = false;
        }

        private async Task Login()
        {
            
            try
            {
                IsBusy = true;

                await App.Current.MainPage.Navigation.PushAsync(new SignUpPrompt());

            }
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task Help()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SupportPage());
        }

        #endregion

    }
}
