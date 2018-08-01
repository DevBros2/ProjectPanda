using Newtonsoft.Json;
using ProjectPanda.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.ViewModels
{
    public class PaymentViewModel
    {
        private async Task MakePayment()
        {
            HttpClient client = new HttpClient();

            await client.PostAsync("https//projectpanda.azurewebsites.net/api/payment",
                                    new StringContent(JsonConvert.SerializeObject(new PaymentModel()
                                    {
                                        Amount = "80",
                                        Token = "what i recieve from stripe"
                                    }),
                                    Encoding.UTF8,
                                    "application/json"
                                    ));
        }
    }
}
