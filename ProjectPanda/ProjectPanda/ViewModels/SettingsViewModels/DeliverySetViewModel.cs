using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace ProjectPanda.ViewModels.SettingsViewModels
{
    public class DeliverySetViewModel:BaseViewModel
    {
        private bool isSelected;

        protected object height;

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }

            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public DeliverySetViewModel()
        {

        }
    }
}
