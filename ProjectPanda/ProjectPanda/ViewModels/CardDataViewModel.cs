using System;
using System.Collections.Generic;
using ProjectPanda.Models;
using ProjectPanda.Services;

using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectPanda.ViewModels
{
    public class CardDataViewModel
    {
        public IDataStore<CardDataModel> DataStore;
        public ObservableCollection<CardDataModel> dataList { get; set; }
        public Command LoadDataCommand { get; set; }

        public CardDataViewModel()
        {
            dataList = new ObservableCollection<CardDataModel>();
            LoadDataCommand = new Command(async () => await ExecuteDataCommand());

        }

        async Task ExecuteDataCommand()
        {

            try
            {
                dataList.Clear();
                var carddata = await DataStore.GetItemsAsync(true);
                foreach(var data in carddata)
                {
                    dataList.Add(data);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                var IsBusy = false;
            }
        }
    }   
}

