using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectPanda.Models
{
    public class UserRegistration
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName ="First Name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName ="Surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName ="Email Address")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName ="Cell phone")]
        public string Cellphone { get; set; }

        [JsonProperty(PropertyName ="Blood Type")]
        public string BloodType { get; set; }

        [JsonProperty(PropertyName ="Medical Aid")]
        public string MedicalAid { get; set; }

        [JsonProperty(PropertyName = "Dependencies")]
        public bool Dependencies { get; set; }
    }
}
