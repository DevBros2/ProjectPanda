using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models.DetailUserModel
{
    public class ChronicDiseaseListModel
    {
        public string Id { get; set; }

        public string ChronicIcon{ get; set; }

        public string ChronicName{ get; set; }


        public const string Icon = "chronicIcon.png";

        public const string Title = "Chronic Disease(s)";
    }
}
