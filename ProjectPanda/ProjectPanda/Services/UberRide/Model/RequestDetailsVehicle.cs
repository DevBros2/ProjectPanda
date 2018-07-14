using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
     public class RequestDetailsVehicle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty(PropertyName = "picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }
    }
}
