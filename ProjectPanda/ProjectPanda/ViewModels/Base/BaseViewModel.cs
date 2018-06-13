using ProjectPanda.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectPanda.ViewModels.Base
{
     public class BaseViewModel:INotifyPropertyChanged
    {
        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       public static void SetActivityIndicatorStatus(bool isNetworkConnectionActive)
        {
            if (isNetworkConnectionActive)
            {
                _networkIndicatorCount++;
                Device.BeginInvokeOnMainThread(() => Application.Current.MainPage.IsBusy = true);
            }
            else if (--_networkIndicatorCount <= 0)
            {
                _networkIndicatorCount = 0;
                Device.BeginInvokeOnMainThread(() => Application.Current.MainPage.IsBusy = false);
            }
}
    }
}
