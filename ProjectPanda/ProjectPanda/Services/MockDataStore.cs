using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectPanda.Models;
using System.Threading.Tasks;

namespace ProjectPanda.Services
{
    public class MockDataStore
    {

        List<CardDataModel> cardData;

        public MockDataStore()
        {
            cardData = new List<CardDataModel>();
            var mockCardData = new List<CardDataModel>
            {
                new CardDataModel { ActivityRate ="Activity rate is 150% ", NameOfPractice ="Clermont Clinic", HeadLinesDesc ="The Independent is a British online newspaper.[2]............", ProfileImage =""},
                new CardDataModel { ActivityRate  ="Activity rate is 150% ", NameOfPractice ="Clermont Clinic", HeadLinesDesc ="The Independent is a British online newspaper.[2]............", ProfileImage =""},
                new CardDataModel { ActivityRate  ="Activity rate is 150% ", NameOfPractice ="Clermont Clinic", HeadLinesDesc ="", ProfileImage =""},
                new CardDataModel { ActivityRate  ="Activity rate is 150% ", NameOfPractice ="Clermont Clinic", HeadLinesDesc ="", ProfileImage =""},
                new CardDataModel { ActivityRate  ="Activity rate is 150% ", NameOfPractice ="Clermont Clinic", HeadLinesDesc ="", ProfileImage =""}
            };
            //loads all the data into the listview
            foreach (var data in mockCardData)
            {
                cardData.Add(data);
            }
           
         }
        public async Task<CardDataModel> GetItemAsync(string headtitle)
        {
            return await Task.FromResult(cardData.FirstOrDefault(s => s.HeadTitle == headtitle));
        }
        public async Task<IEnumerable<CardDataModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(cardData);
        }
    }
}
