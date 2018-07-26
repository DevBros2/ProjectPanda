using SerapisPatientWebService.Models;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using SerapisPatientWebService.DataObjects;

namespace SerapisPatientWebService.Controllers
{
    [Route("api/[controller]")]
    public class PaymentModelsController : ApiController
    {
        string stringid;
        [HttpPost]
        public IActionResult Post([FromBody]PaymentModel payment)
        {
            // You can optionally create a customer first, attached this to patientID
            var charge = new StripeChargeCreateOptions
            {
                Amount = Convert.ToInt32(payment.Amount) * 100, //The default value is in cents, hence multply by 100
                Currency = "ZAR",
                Description = "We Must bind the product details here",
                SourceTokenOrExistingSourceId = payment.Token

            };
            var service = new StripeChargeService("sk-testxxxxxx");//api key

            try
            {
                //BONGA: I keep getting an error for the next line of code, will come back to it when we need to set up
                //var response = service.Capture(charge); 
                   
                
                //Record or do something with charge info
            }
            catch(StripeException ex)
            {
                StripeError stripeError = ex.StripeError;

                //handle error
            }
            return OK(true);//will have to revisit this
        }

        private IActionResult OK(bool v)
        {
            throw new NotImplementedException();
        }
    }
}