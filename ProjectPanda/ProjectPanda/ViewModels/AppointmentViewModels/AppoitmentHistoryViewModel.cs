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

namespace ProjectPanda.ViewModels
{
    public class AppoitmentHistoryViewModel
    {

        public ObservableCollection<AppoitmentHistoryModel> _History { get; set; }
        public object SelectedItem { get; set; }
        public Command RemoveAppointmentLog { get; }

        public AppoitmentHistoryViewModel()
        {
            GenerateAppoitmentHistory();

          //  RemoveAppointmentLog = new Command(() => ));
        }

        /*
        public void RemoveLog(AppoitmentHistoryModel appoitmentlog)
        {
            _History.Remove(appoitmentlog);
        }
        */
        

        private void GenerateAppoitmentHistory()
        {
            _History = new ObservableCollection<AppoitmentHistoryModel>
            {
                new AppoitmentHistoryModel{DateSeen="21/01/2018", DoctorSeen="Dr K.L Buthelezi", Time="09h23m"},
                new AppoitmentHistoryModel{DateSeen="03/09/2017", DoctorSeen="Dr R Rox", Time="14h00m" },
                new AppoitmentHistoryModel{DateSeen="21/01/2018", DoctorSeen="Dr A Xulu", Time="09h23m"}
            };
        }


    }
}
