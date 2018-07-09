using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using ProjectPanda.Models.DetailUserModel;

namespace ProjectPanda.Models
{
    public class PatientInfo
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName ="First Name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName ="Surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName ="EmailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName ="Cellphone")]
        public string Cellphone { get; set; }

        [JsonProperty(PropertyName ="BloodType")]
        public string BloodType { get; set; }

        [JsonProperty(PropertyName ="MedicalAid")]
        public string MedicalAid { get; set; }

        [JsonProperty(PropertyName = "MedicalAidPatient")]
        public bool MedicalAidPatient { get; set; }

        [JsonProperty(PropertyName = "HasDependencies")]
        public bool HasDependencies { get; set; }

        [JsonProperty(PropertyName = "IsDependency")]
        public bool IsDependency { get; set; }

        [JsonProperty(PropertyName = "NumOfDependencies")]
        public int NumOfDependencies { get; set; }

        [JsonProperty(PropertyName = "GetDependcyDetails")]
        public DependencyDetails GetDependencyDetails { get; set; }

        [JsonProperty(PropertyName = "Allergies")]
        public List<AllergiesModel> Allergies { get; set; }

        [JsonProperty(PropertyName = "ChronicDiseases")]
        public List<ChronicDiseaseListModel> ChronicDiseases { get; set; }

        [JsonProperty(PropertyName = "MedicationTaken")]
        public List<MedicationModel> MedicationTaken { get; set; }

        [JsonProperty(PropertyName = "Age")]
        public string Age { get; set; }

        [JsonProperty(PropertyName = "Gender")]
        public string Gender { get; set; }


    }
}
