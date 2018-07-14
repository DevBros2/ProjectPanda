using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
     public class Promotion
    {
        [JsonProperty(PropertyName = "display_text")]
        public string DisplayText { get; set; }

        [JsonProperty(PropertyName = "localized_value")]
        public string LocalizedValue { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
