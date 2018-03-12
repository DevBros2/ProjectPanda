using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Pages;
namespace ProjectPanda.Models
{
      public class AppoitmentHistoryModel
    {
        private string dateseen;
        private string time;
        private string doctorSeen;

        public string DateSeen
        {
            get
            {
                return dateseen;
            }

            set
            {
                dateseen = value;
            }
        }


        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }


        public string DoctorSeen
        {
            get
            {
                return doctorSeen;
            }
            set
            {
                doctorSeen = value;
            }
        }
    }
}
