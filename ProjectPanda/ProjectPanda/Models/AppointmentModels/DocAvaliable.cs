using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace ProjectPanda.Models
{
    public class DocAvaliable : Appointment
    {
        [BsonId]
        public ObjectId Id { get; set; }

        //[BsonElement("id")]
        //public string Id { get; set; }

        [BsonElement("docName")]
        public string DocName { get; set; }

        [BsonElement("varsity")]
        public string Varsity { get; set;}

        [BsonElement("profileimageurl")]
        public string ProfileImageURl { get; set; }

        [BsonElement("medicalbuilding")]
        public string MedicalBuilding { get; set; }

        [BsonElement("complete")]
        public bool Complete { get; set; }
        
        [BsonElement("docSpecilization")]
        public Specilization DocSpecilization { get; set; }
        //not sure what this property does
        public bool IsVisible { get; set; }

    }
}
