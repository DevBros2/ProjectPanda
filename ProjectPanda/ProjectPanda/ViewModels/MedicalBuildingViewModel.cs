using ProjectPanda.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectPanda.ViewModels
{
    public class MedicalBuildingViewModel
    {
        public IList<MedicalBuildingModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }
        public MedicalBuildingViewModel()
        {
            CardDataCollection = new List<MedicalBuildingModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            
                CardDataCollection = new ObservableCollection<MedicalBuildingModel>
                {
                    new MedicalBuildingModel
                    {
                     HeadTitle = " Activity rate is 150% - Clermont Clinic",

                     HeadLines="Clermont Clinic. We are a government/public organisation. We are a provincial primary healthcare facility providing HIV and TB-related treatment, care and support services." ,
                     ProfileImage = "Person_7.jpg",
                     HeadLinesDesc = "",

                    },



                     new MedicalBuildingModel
                    {
                     HeadTitle = " Activity rate is 15%  - Groote Schuur Hospital",
                     HeadLines= " Groote Schuur Hospital is a large, government-funded, teaching hospital situated on the slopes of Devil's Peak in the city of Cape Town, South" ,
                     HeadLinesDesc = "The Independent is a British online newspaper.[2]............small sample based on your scenario. Please review my project and let us know",

                     ProfileImage = "Person_2.png"
                     },



                      new MedicalBuildingModel
                    {
                    HeadTitle       = "Activity rate is 15% - Grey's Hospital",
                    HeadLines         ="Grey's Hospital is a referral/tertiary hospital providing 100% tertiary services to patients and is located in Pietermaritzburg " ,
                     HeadLinesDesc     = "Microsoft Corporation (/ˈmaɪkrəˌsɒft/,[2][3] abbreviated.............small sample based on your scenario. Please review my project and let us know",

                      ProfileImage     = "Person_3.png"
                      },


                       new MedicalBuildingModel
                    {
                    HeadTitle = " 13 hrs ago  - MacRumors ",
                      HeadLines    = "MacRumors.com is a website that aggregates Mac and Apple",
                     HeadLinesDesc="Google Rolls Out Anti-Polishing Feature to Gmail on Ios",
                     ProfileImage = "Person_4.jpg"

                       },


                        new MedicalBuildingModel
                    {
                    HeadTitle= " 15 hrs ago - Android Authority",
                   HeadLinesDesc  = "If you have read Jules Verne’s Around the World...........small sample based on your scenario. Please review my project and let us know" ,
                     HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                     ProfileImage = "Person_5.jpg"
                        },


                       new  MedicalBuildingModel
                    {
                      HeadTitle = " 16 hrs ago - MacRumors",
                      HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple related news................small sample based on your scenario. Please review my project and let us know,",
                      HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                      ProfileImage = "Person_1.png"
                         },


                          new MedicalBuildingModel
                    {
                     HeadTitle = " 19 hrs ago  - Android Authority",
                      HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple.........small sample based on your scenario. Please review my project and let us know",
                      HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                      ProfileImage = "Person_2.png"
                          },
                   
                 //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model
                };



            }

        

    }
}
