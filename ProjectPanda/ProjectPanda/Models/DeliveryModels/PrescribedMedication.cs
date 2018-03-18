using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public  class PrescribedMedication
    {

        private string medication;
        private string dosageamount;
        private string medicationdescription;
     


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
                return medicationdescription;
            }

            set
            {
                medication = value;
            }
        }



    }
}
