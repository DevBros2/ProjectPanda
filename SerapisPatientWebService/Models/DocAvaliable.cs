using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace SerapisPatientWebService.Models
{
    public class DocAvaliable 
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "varsity")]
        public string Varsity { get; set;}

        [JsonProperty(PropertyName = "profileimageurl")]
        public string ProfileImageURl { get; set; }

        [JsonProperty(PropertyName = "medicalbuilding")
        public string MedicalBuilding { get; set; }
        
        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }
        
        [JsonProperty(PropertyName = "complete")]
        public DateTime date{ get; set;
        
        public bool IsVisible { get; set; }

    }
}
