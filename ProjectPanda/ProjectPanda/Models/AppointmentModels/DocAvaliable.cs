using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace ProjectPanda.Models
{
    public class DocAvaliable : INotifyPropertyChanged
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "varsity")]
        public string Varsity { get; set;}

        [JsonProperty(PropertyName = "profileimageurl")]
        public string ProfileImageURl { get; set; }


        [JsonProperty(PropertyName = "medicalbuilding")]
        public string MedicalBuilding { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        public bool IsVisible { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public static implicit operator string(DocAvaliable v)
        {
            throw new NotImplementedException();
        }
    }
}
