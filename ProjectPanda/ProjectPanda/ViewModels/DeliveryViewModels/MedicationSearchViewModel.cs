using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DeliveryViewModel
{
    public class MedicationSearchViewModel:BaseViewModel
    {
        List<String> Medslist = new List<string>
        {
            "","","","","","","","","","","","","","","","","","","","","","","","","","",
        };
        public MedicationSearchViewModel()
        {
                   
           // GenerateMedicationList();
        }

        private void GenerateMedicationList()
        {
           
        }
    }
}
