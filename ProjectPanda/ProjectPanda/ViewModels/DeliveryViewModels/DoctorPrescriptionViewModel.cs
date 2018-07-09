using ProjectPanda.Models;
using ProjectPanda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
     public class DoctorPrescriptionViewModel:BaseViewModel
    {

        public ObservableCollection<PrescribedMedication> MedicationList { get; set; }

        public DoctorPrescriptionViewModel()
        {
            GenerateDummyList();
        }

        private void GenerateDummyList()
        {
            MedicationList = new ObservableCollection<PrescribedMedication>()
            {
                new PrescribedMedication{ DosageAmount="23mg/hl", Medication="Zyphron", MedicationDescription="Take 3 a day, after every meal"},
                new PrescribedMedication{ DosageAmount="10mg/hl", Medication="Zyphron", MedicationDescription="Take one when you feel pain"},
                new PrescribedMedication{ DosageAmount="67mg/hl", Medication="Zyphron", MedicationDescription="Take one and sleep"}
            };
        }
    }
}
