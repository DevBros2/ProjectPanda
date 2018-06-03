namespace SerapisPatientWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class PatientUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("cellPhoneNumber")]
        public string CellPhoneNumber { get; set; }

        [JsonProperty("detailfilladdre/ssLine1")]
        public string DetailfilladdreSsLine1 { get; set; }

        [JsonProperty("detailfilladdressLine2")]
        public string DetailfilladdressLine2 { get; set; }

        [JsonProperty("deatilfilltownAndCity")]
        public string DeatilfilltownAndCity { get; set; }

        [JsonProperty("detailfillPostal")]
        public string DetailfillPostal { get; set; }

        [JsonProperty("Blood type")]
        public string BloodType { get; set; }

        [JsonProperty("Medical Aid")]
        public string MedicalAid { get; set; }

        [JsonProperty("Number of Dependencies")]
        public int NumberOfDependencies { get; set; }

        [JsonProperty("dependency")]
        public List<Dependency> Dependency { get; set; }
    }

    public partial class Dependency
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("cellPhoneNumber")]
        public string CellPhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("Blood type")]
        public string BloodType { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { 
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
