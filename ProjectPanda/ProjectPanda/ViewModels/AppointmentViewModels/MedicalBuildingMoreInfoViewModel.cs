using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models;

namespace ProjectPanda.ViewModels.AppointmentViewModels
{
     public class MedicalBuildingMoreInfoViewModel:MedicalBuildingModel
    {
        public ObservableCollection<MedicalBuildingModel> moreInformation { get; set; }


        public MedicalBuildingMoreInfoViewModel()
        {
            MoreInformationDisplay(); 
        }

        private void MoreInformationDisplay()
        {
            moreInformation = new ObservableCollection<MedicalBuildingModel> {

                new MedicalBuildingModel{ PracticeName="Grey's Hospital", Distance="7.8Km", ProfileImage="GreysHospital.jpg"}

            };
        }
    }
}
