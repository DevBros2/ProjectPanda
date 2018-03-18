using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Xml.Serialization;
using ProjectPanda.Pages;
using ProjectPanda.ViewModels;

namespace ProjectPanda.Models
{
      public class AppoitmentHistoryModel
    {

        #region Global Variables
        private string dateseen;
        private string time;
        private string doctorSeen;
        #endregion


        #region Properties

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

        #endregion

        /*
        //deleting property
        [XmlIgnore]
        public ICommand RemoveAppointmentLog { get; private set; }
        */
    }
}
