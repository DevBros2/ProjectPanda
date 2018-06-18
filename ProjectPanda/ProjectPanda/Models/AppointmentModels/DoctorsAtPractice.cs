using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models.AppointmentModels
{
    public class DoctorsAtPractice:DocAvaliable
    {

       
        
           // FullName = Name;
           // ProfilePicture = ProfileImageURl;
       
        public string FullName
        {
           set { value= DocName; }
        }


        public string ProfilePicture
        {
            set { value = ProfileImageURl; }
        }

    }
}
