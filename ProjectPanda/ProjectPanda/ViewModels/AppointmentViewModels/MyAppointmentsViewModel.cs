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
        private String _BasicString = "Doctor";
        private string _MyAppointmentsViewModelText;

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

        public MyAppointmentsViewModel()
        {
            MyAppointmentsViewModelText = "Doctor";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //please implement it here

       
    }
}
