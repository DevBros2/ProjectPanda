using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
     public class PriceEstimateCollection
    {
        [JsonProperty(PropertyName = "prices")]
        public IList<PriceEstimate> PriceEstimates { get; set; }
    }
}
