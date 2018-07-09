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
using System.Windows.Input;

namespace ProjectPanda.ViewModels
{
    public class MyAppointmentsViewModel : BaseViewModel
    {
        private string buildingDetails;
        private DateTime dates;
        private TimeSpan times;
        

        public MyAppointmentsViewModel()
        {
            MyAppointmentsViewModelText = "Doctor";
            NavigateToSerapisBooking =new Command(async () => await GoToSerapisBooking());
            NavigateToDateBooking = new Command(async () => await GoToDateBooking());
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
       
        public ICommand NavigateToSerapisBooking { get; set; }

        public ICommand NavigateToDateBooking { get; set; }
        #endregion


        #region Methods
        private async Task GoToSerapisBooking()
        {
           await App.Current.MainPage.Navigation.PushAsync(new FieldsOfSpecialization());
        }

        private async Task GoToDateBooking()
        {
            await App.Current.MainPage.Navigation.PushAsync(new FieldsOfSpecilizationDate());
        }

        #endregion

    }
}
