using ProjectPanda.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels
{
    public class MyAppointmentsViewModel : INotifyPropertyChanged
    {
        #region Variables
        private String _BasicString = "Doctor";
        private string dateLabel;
        private string _MyAppointmentsViewModelText;
        #endregion

        #region Properties
        public string MyAppointmentsViewModelText
        {
            get
            {
                return _MyAppointmentsViewModelText;
            }
            set
            {
                _MyAppointmentsViewModelText = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(MyAppointmentsViewModelText)));
                }
            }
        }

        public string DateTextLabel
        {
            get
            {
                return dateLabel;
            }
            set
            {
                dateLabel = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(dateLabel)));
                }
            }
        }
        #endregion


        public MyAppointmentsViewModel()
        {
            MyAppointmentsViewModelText = "Doctor";
            dateLabel = "Date";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //please implement it here

       
    }
}
