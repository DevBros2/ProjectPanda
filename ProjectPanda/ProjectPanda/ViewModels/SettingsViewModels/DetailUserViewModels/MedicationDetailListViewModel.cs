using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DetailUserModel;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
     public class MedicationDetailListViewModel : BaseViewModel
    {
        public ObservableCollection<MedicationModel> _Medications { get; set; }
        public object SelectedItem { get; set; }

        public MedicationDetailListViewModel()
        {
            GenerateMedicationList();
        }


        private void GenerateMedicationList()
        {
            _Medications = new ObservableCollection<MedicationModel>
            {
                new MedicationModel{dosageofmedication="23ml/g", medicationIcon="medicationBottle.png", titleofmedication="Anti Retro Virals"}

            };

        }
    }
}
