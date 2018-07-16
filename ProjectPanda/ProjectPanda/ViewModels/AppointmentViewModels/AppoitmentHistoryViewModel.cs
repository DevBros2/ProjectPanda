using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.AppointmentModels;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;
using ProjectPanda.Pages.AppointmentHistoryFolder;
using ProjectPanda.ViewModels.Base;
using ProjectPanda.Utils;

namespace ProjectPanda.ViewModels
{
    public class AppoitmentHistoryViewModel:BaseViewModel
    {

       public ObservableCollection<AppoitmentHistoryModel> _History { get; set; }
       public Command RemoveAppointmentLog { get; set; }
       public AppoitmentHistoryModel Item { get; set; }

        #region Constructor
        public AppoitmentHistoryViewModel(AppoitmentHistoryModel item=null)
        {
            GenerateAppoitmentHistory();
            Item = item;

        }
        #endregion

        #region Methods
        private void GenerateAppoitmentHistory()
        {

            _History = new ObservableCollection<AppoitmentHistoryModel>
            {
                new AppoitmentHistoryModel{DateSeen="21/01/2018", DoctorName="", Time="09h23m", TimeSpan="0hrs ,9 mins, 23 secs"},
                new AppoitmentHistoryModel{DateSeen="03/09/2017",DoctorName="", Time="14h00m", TimeSpan="0hrs, 25mins, 50 secs"},
                new AppoitmentHistoryModel{DateSeen="21/01/2018",DoctorName="" ,Time="09h23m", TimeSpan="1hrs, 5 mins, 23 secs"}
            };
        }
        #endregion

    }
}
