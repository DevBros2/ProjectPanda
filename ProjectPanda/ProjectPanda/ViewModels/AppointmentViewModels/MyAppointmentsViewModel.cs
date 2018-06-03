using ProjectPanda.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using ProjectPanda.ViewModels.Base;
using System.Diagnostics;
using ProjectPanda.Models;
using System.Threading.Tasks;
using ProjectPanda.Views.AppoinmentViews;

namespace ProjectPanda.ViewModels
{
    public class MyAppointmentsViewModel :BaseViewModel, INotifyPropertyChanged
    {
        private string buildingDetails;
        private DateTime dates;
        private TimeSpan times;
        public MyAppointmentsViewModel()
        {
            MyAppointmentsViewModelText = "Doctor";
            NavigateToDocPracSelect = new Command(SelectPracAndDoc);
            
            //Temp navigation for testing
            NavigateToCalendarSelect = new Command(SelectDate);
        }

        //Temp
        private void SelectDate()
        {
            App.Current.MainPage.Navigation.PushAsync(new FieldsOfSpecialization());
        }



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

        public DateTime DateTextLabel
        {
            get
            {
                return dates;
            }
            set
            {
                dates= value;
                OnPropertyChanged("DateTextLabel");
            }
        }

        public TimeSpan TimeTextLabel
        {
            get
            {
                return times;
            }
            set
            {
                times = value;
                OnPropertyChanged("TimeTextLabel");
            }
        }

        public string MedicalBuildingId
        {
            get
            {
                return buildingDetails;
            }
            set
            {
                buildingDetails = value;
                OnPropertyChanged("MedicalBuildingId");
            }
        }

        public Command NavigateToDocPracSelect { get; set; }

        public Command NavigateToCalendarSelect { get; set; }

        public Command NavigateToTimeSelect { get; set; }
        #endregion


        new public event PropertyChangedEventHandler PropertyChanged;

        #region Methods
        private void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private async void SelectPracAndDoc()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MedicalBuildingView(), true);
        }

        #endregion

    }
}
