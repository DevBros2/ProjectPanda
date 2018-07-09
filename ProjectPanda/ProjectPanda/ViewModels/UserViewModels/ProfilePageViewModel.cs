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

        PatientInfo info = new PatientInfo();

        public Command NavigateToFiles{ get; set; }

        public ObservableRangeCollection<PatientCard> ListPatientInformation { get; set; }
      
        public ProfilePageViewModel()
        {
            NavigateToFiles = new Command(GoToPrivateInformation);
            LoadPatientInformation();
        }


        private async void  GoToPrivateInformation()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailedUserInfo());
        }

        private void LoadPatientInformation()
        {
            ListPatientInformation = new ObservableRangeCollection<PatientCard>()
            {
               new PatientCard{Title=info.Age="21", Icon="Age.png", SubTitle="Age"},
               new PatientCard{Title=info.MedicalAid="Bonitas", Icon="MedicalAid.png", SubTitle="Medical aid"},
               new PatientCard{Title=info.Gender="Male", Icon="gender.png", SubTitle="Gender"},
               new PatientCard{Title=info.BloodType="A+", Icon="Blood.png", SubTitle="Blood type"}
            };
        }


    }
}
