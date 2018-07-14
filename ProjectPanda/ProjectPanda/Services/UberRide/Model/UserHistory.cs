using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
    public class UserHistory
    {
        [JsonProperty(PropertyName = "uuid")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "request_time")]
        public int RequestTime { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public double Distance { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public int StartTime { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        public int EndTime { get; set; }
    }
}
