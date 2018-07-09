using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Models.DetailUserModel;
using ProjectPanda.Utils;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
    public class MedicalFilesViewModel
    {
        public ObservableRangeCollection<MedicalFilesModel> ListOfMedicalFiles { get; set; }


        public MedicalFilesViewModel()
        {
            GenerateFilesList();
        }

        private async Task GenerateFilesList()
        {
            ListOfMedicalFiles = new ObservableRangeCollection<MedicalFilesModel>()
            {
                new MedicalFilesModel{Title="X-Ray", DateEntred=DateTime.Now, DoctorsName="Dr Hugely"}
            };
        }
    }
}
