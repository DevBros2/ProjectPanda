using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProjectPanda.LocalDataBase
{
    [Table("Information")]
    public class User
    {
        [Column("id")]
        public string iD { get; set; }

        [Column("First Name")]
        public string First_Name { get; set; }

        [Column("surname")]
        public string surname { get; set; }

        [Column("emailAddress")]
        public string emailAdrres { get; set; }

        [Column("Cell phone")]
        public string cellPhone { get; set; }

        [Column("BloodType")]
        public string bloodtype { get; set; }

        [Column("MedicalAid")]
        public string medicalAid { get; set; }

        [Column("dependencies")]
        public bool dependencies { get; set; }

        //add all the other attributes again later on 
    }
}
