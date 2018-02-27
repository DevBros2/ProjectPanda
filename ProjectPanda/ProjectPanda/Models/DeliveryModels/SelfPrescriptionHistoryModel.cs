using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
namespace ProjectPanda.Models.DeliveryModels
{
    //could inheret from the PrecriptionHistory class, this will do for now
    public class SelfPrescriptionHistoryModel
    {

      
        //the self prescription medication history
        public string selfMedicationHistory
        {
            get;
            set;
        }


        //self medication dosage history
        public string selfMedicationDosageHistory
        {
            get;
            set;
        }


        //self medication delivery history
        public string selfMedicationDeliveryHistory
        {
            get;
            set;
        }

    }
}
