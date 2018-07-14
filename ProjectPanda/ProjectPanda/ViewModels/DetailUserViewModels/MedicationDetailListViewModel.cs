using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DetailUserModel;
using ProjectPanda.ViewModels.Base;
using Xamarin.Forms;
using System.Threading.Tasks;
using ProjectPanda.Services;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
     public class MedicationDetailListViewModel : BaseViewModel
    {
        
        private bool showSearchElement;
        private double searchAnimation;

        public MedicationDetailListViewModel()
        {
            GenerateMedicationList();
            SearchBar = new Command(async () => await GenerateSearchBar());
            Search = new Command(async () => await SearchMedicalItem());   
        }

        private void GenerateMedicationList()
        {
            _Medications = new ObservableCollection<MedicationModel>
            {
                new MedicationModel{DosageOfMedication="23ML/G", TitleOfMedication="Anti Retro Virals"}
            };

        }

        #region Properties
        public bool ShowSearchElement
        {
            get
            {
                return showSearchElement;
            }
            set
            {
                showSearchElement = value;
                OnPropertyChanged("ShowSearchElement");
            }
        }

        public ObservableCollection<MedicationModel> _Medications { get; set; }

        public object SelectedItem { get; set; }

        public Command SearchBar { get; set; }

        public Command Search { get; set; }

        #endregion

        private async Task GenerateSearchBar()
        {
           ShowSearchElement = true;
        }

        private async Task SearchMedicalItem()
        {
            //search for the medication
        }
    }
}
