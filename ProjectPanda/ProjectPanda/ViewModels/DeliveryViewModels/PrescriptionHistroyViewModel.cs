using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DeliveryModels;
using ProjectPanda.Views;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{

    

    public class PrescriptionHistroyViewModel
    {

        public ObservableCollection<PrecriptionHistory> _historyPrescriptionList { get; set; }
        public object SelectedItem { get; set; }

        public PrescriptionHistroyViewModel()
        {
            GenerateHistoryList();
        }

        private void GenerateHistoryList()
        {
            _historyPrescriptionList = new ObservableCollection<PrecriptionHistory>
            {

                //get the values from the cloud 

            };
        }
    }
}
