using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DeliveryModels;
using ProjectPanda.Views;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DeliveryViewModels
{

    

    public class PrescriptionHistroyViewModel:BaseViewModel
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

                new PrecriptionHistory{ _descriptionHistory="Take 3 times a day after each meal", _dosageHistory="5 times a day", _medicationHistory="Oxycon", MedicationDeliveryDate="27/03/18"}

            };
        }
         

        public void DeleteMedicalHistory(PrecriptionHistory medsDeletion)
        {
            _historyPrescriptionList.Remove(medsDeletion);
        }

    }
}
