using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerapisPatientWebService.Models
{
    public class PaymentModel
    {
        public string Token { get; set; }
        public string Amount { get; set; }
    }
}