using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectPanda.ViewModels
{
    public class AppoitmentHistoryViewModel
    {

        public ObservableCollection<AppoitmentHistoryModel> _History { get; set; }
        public object SelectedItem { get; set; }

        public AppoitmentHistoryViewModel()
        {
            GenerateAppoitmentHistory();
        }


        private void GenerateAppoitmentHistory()
        {
            _History = new ObservableCollection<AppoitmentHistoryModel>
            {
                new AppoitmentHistoryModel{date="21/01/2018", doctorSeen="Dr K.L Buthelezi", time="09h23m"},
                new AppoitmentHistoryModel{date="03/09/2017", doctorSeen="Dr R Rox", time="14h00m" },
                new AppoitmentHistoryModel{date="21/01/2018", doctorSeen="Dr A Xulu", time="09h23m"}
            };
        }


    }
}
