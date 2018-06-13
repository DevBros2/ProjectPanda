using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProjectPanda.Models;
using ProjectPanda.Models.AppointmentModels;
using ProjectPanda.Services.Mongodb;
namespace ProjectPanda.ViewModels.AppointmentViewModels
{
    public class DoctorsAtPracticeViewModel
    {
        public string MongodbServer = "mongodb://localhost:27017";//Since we are testing locally
        public string ActiveDatabase = "RegisteredDoctors";//not tested names
        public string ActiveCollection = "Doctors";
        
        public ObservableCollection<DoctorsAtPractice> _docs { get; set; }

        UsersRepository _mongoDbRepo = new UsersRepository(MongodbServer, ActiveDatabase, ActiveCollection);
        
        public DoctorsAtPracticeViewModel()
        {
           // DummyDataGenerateDoctorsAtPractice();
           loadDoctors();
        }

        private void loadDoctors()
        {
            var connected = mongoDbRepo.CheckConnection();
           if(connected != false)
           try
           {
               //need to implement the Itemtapped
               //must get vaules through MessagingCenter
                var users = await _mongoDbRepo.GetUsersByField(medicalbuilding,DocSpecilization); 
                while(int NumOfDoctors = 0 < users.Count()) //when query is done, it counts amount of fields recieved[users.Count()]
                {
                _docs.Add(users)
                };

           }catch(Exception e)
           {
            //excepetion method here
           }
           return _docs;
        }

        private void DummyDataGenerateDoctorsAtPractice()
        {
            _docs = new ObservableCollection<DoctorsAtPractice>
            {
                new DoctorsAtPractice{Name="Dr Zulu", ProfileImageURl="userplaceholder.png"  },
                new DoctorsAtPractice{Name="Dr Buthelezi", ProfileImageURl="userplaceholder.png}" },
                new DoctorsAtPractice{Name="Dr Zuma", ProfileImageURl="userplaceholder.png}" }
            };
        }


    }
}
