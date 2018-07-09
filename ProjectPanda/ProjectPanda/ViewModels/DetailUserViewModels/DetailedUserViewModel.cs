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
using ProjectPanda.Models.DetailUserModel;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{


    public class DetailedUserViewModel:BaseViewModel
    {
        public Command NavigateToChronicList { get; set; }   
        public Command NavigateToRecurringMeds { get; set; }
        public Command NavigateToAllergiesList { get; set; }
        public Command NavigateToMedicalRecords { get; set; }

        public ObservableCollection<PatientCard> MoreUserInfo { get; set; }

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
            IsBusy = true;

            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new ChronicDiseaseList());
            }
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        
        private async void GoToMedicationList()
        {
            IsBusy = true;

            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new MedicationDetailList());
            }
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }

        }

        private async void GoToAllergiesList()
        {
            IsBusy = false;

            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new AllergiesDetailList());
            }
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void GoToMedicalFiles()
        {
            IsBusy = true;

            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new MedicalRecords());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        #endregion

    }
}
