using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DetailUserModel;
using ProjectPanda.ViewModels.Base;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
    public  class AllergiesDetailListViewModel : BaseViewModel
    {
        public ObservableCollection<AllergiesModel> _allergies { get; set; }
        public object SelectedItem { get; set; }

        public AllergiesDetailListViewModel()
        {
            GenerateAllergiesList();
        }



        private void GenerateAllergiesList()
        {
            _allergies = new ObservableCollection<AllergiesModel>
            {
                new AllergiesModel{AllergyName="Pets", AllergyIcon="allergiesIcon.png"}

            };
        }

    }
}
