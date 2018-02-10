using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;

namespace ProjectPanda.Models.DeliveryModels
{
    public class PrecriptionHistory: PrescribedMedication
    {

        public string _medicationHistory;
        public string _dosageHistory;
        public string _descriptionHistory;

        //property to  get and set to the histroy listview 
        public string MedicationNameHistory
        {
            get { return _medicationHistory; }

            set { _medicationHistory = Medication; }
            
        }
            

        //property to get and set to the history listview
       public string MedicationDosageHistory
        {
            get { return _dosageHistory; }

            set { _dosageHistory = DosageAmount; }
        }


        public string DescriptionHistory
        {
            get { return _descriptionHistory; }

            set { _descriptionHistory = DescriptionHistory; }
        }


    }
}
