using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DeliveryModels;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
     public class SelfPrescriptionHistoryViewModel : BaseViewModel
    {
        public ObservableCollection<SelfPrescriptionHistoryModel> _selfPrescriptionHistoryList { get; set; }

        public SelfPrescriptionHistoryViewModel()
        {
            GenerateSelfPrescriptionHistory();
        }

        private void GenerateSelfPrescriptionHistory()
        {
            _selfPrescriptionHistoryList = new ObservableCollection<SelfPrescriptionHistoryModel>
            {
                new SelfPrescriptionHistoryModel{ SelfMedicationDeliveryHistory="15/03/18", SelfMedicationHistory="Panado", SelfMedicationDosageHistory="8mL/g" }
            };
        }
    }
}
