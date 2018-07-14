using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
     public class TimeEstimateCollection
    {
        [JsonProperty(PropertyName = "times")]
        public IList<TimeEstimate> TimeEstimates { get; set; }
    }
}
