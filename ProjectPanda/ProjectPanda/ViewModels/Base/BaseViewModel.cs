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

        private void OnPropertyChanged(string propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
