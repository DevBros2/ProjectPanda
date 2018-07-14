using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
    public class RequestMap
    {
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }

        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }
    }
}
