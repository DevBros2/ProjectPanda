using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class PrescribedMedication
    {

        private string medication;
        private string dosageamount;
        private string medicationDescription;
        private string addedNotes;
        private string medicationTitle;
        private string dosageAmountTitle;
        private string addedNotesTitle;
        private string medicationDescriptionTitle;
        private string id; 


        public string MedicationTitle
        {
            get
            {
                return medicationTitle;
            }
            set
            {
                medicationTitle = value;
            }
        }

        public string DosageAmountTitle
        {
            get
            {
                return dosageAmountTitle;
            }
            set
            {
                dosageAmountTitle = value;
            }
        }

        public string MedicationDescriptionTitle
        {
            get
            {
                return medicationDescriptionTitle;
            }
            set
            {
                medicationDescriptionTitle = value;
            }
        }

        public string Medication
        {
            get
            {
                return medication;
            }

            set
            {
                medication = value;
            }
        }

        public string DosageAmount
        {
            get
            {
                return dosageamount;
            }

            set
            {
                dosageamount = value;
            }
        }

        public string MedicationDescription
        {
            get
            {
                return medicationDescription;
            }

            set
            {
                medicationDescription = value;
            }
        }

        public string AddedNotes
        {
            get
            {
                return addedNotes;
            }
            set
            {
                addedNotes = value;
            }
        }

    }
}
