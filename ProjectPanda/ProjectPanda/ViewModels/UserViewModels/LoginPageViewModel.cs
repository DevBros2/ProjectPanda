using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjectPanda.ViewModels.UserViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
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
                RaisePropertyChanged();

            }
        }

        public LoginPageViewModel()
        {
            SignInRequired = true;
        }

        public void SignIn()
        {
            SignInRequired = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            var propChanged = PropertyChanged;
            if (propChanged != null)
            {
                propChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
