using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
    public class ProductCollection
    {
        [JsonProperty(PropertyName = "products")]
        public IList<Product> Products { get; set; }
    }
}
