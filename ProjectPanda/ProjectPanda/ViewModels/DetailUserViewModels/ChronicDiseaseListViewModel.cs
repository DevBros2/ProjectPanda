using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DetailUserModel;
using ProjectPanda.Models;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
    public class ChronicDiseaseListViewModel : BaseViewModel
    {
        public ObservableCollection<ChronicDiseaseListModel> _Chronic { get; set; }
        public object SelectedItem { get; set; }

        public ChronicDiseaseListViewModel()
        {
            GenerateChronicList();
        }


        private void GenerateChronicList()
        {
            _Chronic = new ObservableCollection<ChronicDiseaseListModel>
            {
                new ChronicDiseaseListModel{ ChronicIcon="chronicDisease.png", ChronicName="HIV/AIDS"},
                new ChronicDiseaseListModel{ChronicIcon="chronicDisease.png", ChronicName="Diabetes"}
            };
        }

    }
}
