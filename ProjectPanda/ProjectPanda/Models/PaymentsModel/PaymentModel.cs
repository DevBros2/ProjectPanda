using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
     public class PaymentModel
    {
        //The marchent logo
        public string CardIcon { get; set; }

        public string CardNumber { get; set; }
        
        public string ExpDate { get; set; }

        public string CVV { get; set; }
    }
}
