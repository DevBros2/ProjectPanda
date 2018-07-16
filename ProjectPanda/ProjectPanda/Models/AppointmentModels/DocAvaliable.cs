using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProjectPanda.Models.AppointmentModels;

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

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("middleName")]
        public string MiddleName { get; set; }

        [BsonElement("practiceLocation")]
        public PracticeLocation PracticeLocation { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("varsity")]
        public string Varsity { get; set;}

        [BsonElement("profileimageurl")]
        public string ProfileImageURl { get; set; }

        [BsonElement("medicalBuilding")]
        public string MedicalBuilding { get; set; }

        [BsonElement("complete")]
        public bool Complete { get; set; }
        
        [BsonElement("docSpecilization")]
        public Specilization DocSpecilization { set; get; }
       
        public bool IsVisible { get; set; }
    }
}
