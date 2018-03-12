using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
namespace ProjectPanda.Models.DeliveryModels
{
    //could inheret from the PrecriptionHistory class, this will do for now
    public class SelfPrescriptionHistoryModel
    {

        private string selfMedicationDeliveryHistory;
        private string selfMedicationDosageHistory;
        private string selfMedicationHistory;


        //the self prescription medication history
        public string SelfMedicationHistory
        {
            get
            {
                return selfMedicationHistory;
            }
            set
            {
                selfMedicationHistory = value;
            }
        }


        //self medication dosage history
        public string SelfMedicationDosageHistory
        {
            get
            {
                return selfMedicationDosageHistory;
            }
            set
            {
                selfMedicationDosageHistory = value;
            }
        }


        //self medication delivery history
        public string SelfMedicationDeliveryHistory
        {
            get
            {
                return selfMedicationDeliveryHistory;
            }
            set
            {
                selfMedicationDeliveryHistory = value;
            }
        }

    }
}
