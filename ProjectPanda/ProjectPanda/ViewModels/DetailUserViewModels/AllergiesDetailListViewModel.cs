using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models.DetailUserModel;

namespace ProjectPanda.ViewModels.DetailUserViewModels
{
    public  class AllergiesDetailListViewModel
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
                new AllergiesModel{AllergyName="Pets", AllergyIcon="prohibition.png"}

            };
        }

    }
}
