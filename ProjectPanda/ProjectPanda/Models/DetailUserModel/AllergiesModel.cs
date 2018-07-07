using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProjectPanda.Models.DetailUserModel
{
     public class AllergiesModel
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string AllergyName { get; set; }

        public string AllergyIcon { get; set; }

    }

}
