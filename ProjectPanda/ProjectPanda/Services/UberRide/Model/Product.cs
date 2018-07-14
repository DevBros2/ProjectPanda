using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
    public class Product
    {
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
    }
}
