using ProjectPanda.Models;
using ProjectPanda.Utils;
using ProjectPanda.ViewModels.Base;
using ProjectPanda.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.UserViewModels
{
     public class ProfilePageViewModel:ObservableRangeCollection<PatientInfo>, INotifyPropertyChanged
    {
        public ObservableRangeCollection<PatientInfo> listPatientInformation;

        public Command NavigateToFiles{ get; set; }

        public ObservableRangeCollection<PatientInfo> ListPatientInformation { get; set; }
      

        public ProfilePageViewModel()
        {
            NavigateToFiles = new Command(GoToPrivateInformation);
            ListPatientInformation = new ObservableRangeCollection<PatientInfo>();
        }


        private async void  GoToPrivateInformation()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailedUserInfo());
        }

        private async Task LoadPatientInformation()
        {

            //list all the patient information here
            foreach (var info in ListPatientInformation)
            {
                ListPatientInformation.Add(info);
            }
        }


    }
}
