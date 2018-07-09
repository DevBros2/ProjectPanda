using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace ProjectPanda.Models.DetailUserModel
{
    public class MedicalFilesModel
    {
        public ObjectId Id { get; set; }
        
        public string Title { get; set; }

        public DateTime DateEntred{ get; set; }

        public string DoctorsName { get; set; }
    }
}
