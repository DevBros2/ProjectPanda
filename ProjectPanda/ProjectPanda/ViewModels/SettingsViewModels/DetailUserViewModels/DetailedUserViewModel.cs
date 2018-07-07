using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Views.ProfilePageViews.UserPrivateDetailedInfo;
using System.Collections.ObjectModel;
using ProjectPanda.Models;
using System.ComponentModel;
using ProjectPanda.ViewModels.Base;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{


    public class DetailedUserViewModel:BaseViewModel
    {
        public Command NavigateToChronicList { get; set; }   
        public Command NavigateToRecurringMeds { get; set; }
        public Command NavigateToAllergiesList { get; set; }
        public Command NavigateToMedicalRecords { get; set; }

        public DetailedUserViewModel()
        {
            NavigateToAllergiesList = new Command(GoToAllergiesList);
            NavigateToChronicList = new Command(GoToChronicList);
            NavigateToRecurringMeds = new Command(GoToMedicationList);
            NavigateToMedicalRecords = new Command(GoToMedicalFiles);
        }

        #region Methods
        
        private async void GoToChronicList()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ChronicDiseaseList());
        }
        
        private async void GoToMedicationList()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MedicationDetailList());
        }

        private async void GoToAllergiesList()
        {

            await App.Current.MainPage.Navigation.PushAsync(new AllergiesDetailList());
        }

        private async void GoToMedicalFiles()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MedicalRecords());
        }

        #endregion

    }
}
