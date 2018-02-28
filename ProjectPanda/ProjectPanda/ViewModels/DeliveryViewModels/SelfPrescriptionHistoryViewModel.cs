﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DeliveryModels;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{
     public class SelfPrescriptionHistoryViewModel
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
                new SelfPrescriptionHistoryModel{ selfMedicationDeliveryHistory="15/03/18", selfMedicationHistory="Panado", selfMedicationDosageHistory="8mL/g" }
            };
        }
    }
}