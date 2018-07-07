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
       

        public MedicalBuildingMoreInfoViewModel()
        {
            
            MoreInformationDisplay(); 
        }

        private void MoreInformationDisplay()
        {

            new MedicalBuildingModel { PracticeName = "Grey's Hospital", Distance = 7.8, MedicalBuildingImage = "GreysHospital.jpg", PatientsCurrentlyAtPractice = 8, AvgTimeSpent = 12 };

        }
    }
}
