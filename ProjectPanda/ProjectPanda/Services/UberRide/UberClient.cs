using Newtonsoft.Json;
using ProjectPanda.Services.UberRide.Interfaces;
using ProjectPanda.Services.UberRide.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.Services.UberRide
{

    public class UberClient : IUberClient
    {

        protected readonly HttpClient _httpClient;

        public async Task<UberResponse<bool>> CancelRequestAsync(string requestId)
        {
            var url = string.Format("/v1/requests/{0}", requestId);

            return await DeleteAsync(url);
        }

        public async Task<UberResponse<PriceEstimateCollection>> GetPriceEstimateAsync(float startLatitude, float startLongitude, float endLatitude, float endLongitude)
        {
            var url = string.Format(
                "/v1/estimates/price?start_latitude={0}&start_longitude={1}&end_latitude={2}&end_longitude={3}",
                startLatitude, startLongitude, endLatitude, endLongitude);

            return await GetAsync<PriceEstimateCollection>(url);
        }

        public async Task<UberResponse<ProductCollection>> GetProductsAsync(float latitude, float longitude)
        {
            var url = string.Format(
                "/v1/products?latitude={0}&longitude={1}",
                latitude, longitude);

            return await GetAsync<ProductCollection>(url);
        }

        public async Task<UberResponse<Promotion>> GetPromotionAsync(float startLatitude, float startLongitude, float endLatitude, float endLongitude)
        {
            var url = string.Format(
               "/v1/promotions?start_latitude={0}&start_longitude={1}&end_latitude={2}&end_longitude={3}",
               startLatitude, startLongitude, endLatitude, endLongitude);

            return await GetAsync<Promotion>(url);
        }

        public async Task<UberResponse<RequestDetails>> GetRequestDetailsAsync(string requestId)
        {
            var url = string.Format("/v1/requests/{0}/map", requestId);

            return await GetAsync<RequestDetails>(url);
        }

        public async Task<UberResponse<RequestMap>> GetRequestMapAsync(string requestId)
        {
            var url = string.Format("/v1/requests/{0}", requestId);

            return await GetAsync<RequestMap>(url);
        }

        public async Task<UberResponse<TimeEstimateCollection>> GetTimeEstimateAsync(float startLatitude, float startLongitude, string customerId, string productId)
        {
            var url = string.Format(
               "/v1/estimates/time?start_latitude={0}&start_longitude={1}",
               startLatitude, startLongitude);

            if (!string.IsNullOrWhiteSpace(customerId))
            {
                url += string.Format("&customer_uuid={0}", customerId);
            }

            if (!string.IsNullOrWhiteSpace(productId))
            {
                url += string.Format("&product_id={0}", productId);
            }

            return await GetAsync<TimeEstimateCollection>(url);
        }

        public async Task<UberResponse<UserActivity>> GetUserActivityAsync(int offset, int limit)
        {
            var url = string.Format(
               "/v1.1/history?offset={0}&limit={1}",
               offset, limit);

            return await GetAsync<UserActivity>(url);
        }

        public async Task<UberResponse<UserProfile>> GetUserProfileAsync()
        {
            var url = string.Format("/v1/me");

            return await GetAsync<UserProfile>(url);
        }

        public async Task<UberResponse<Request>> RequestAsync(string productId, float startLatitude, float startLongitude, float endLatitude, float endLongitude, string surgeConfirmationId = null)
        {
            var url = "/v1/requests";

            var postData = new Dictionary<string, string>
            {
                { "product_id", productId },
                { "start_latitude", startLatitude.ToString("0.00000") },
                { "start_longitude", startLongitude.ToString("0.00000") },
                { "end_latitude", endLatitude.ToString("0.00000") },
                { "end_longitude", endLongitude.ToString("0.00000") },
            };

            if (!string.IsNullOrWhiteSpace(surgeConfirmationId))
            {
                postData.Add("surge_confirmation_id", surgeConfirmationId);
            }

            var content = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");

            return await PostAsync<Request>(url, content);
        }


        private async Task<UberResponse<T>> GetAsync<T>(string url)
        {
            var uberResponse = new UberResponse<T>();

            var response = await _httpClient
                .GetAsync(url)
                .ConfigureAwait(false);

            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                uberResponse.Data = JsonConvert.DeserializeObject<T>(responseContent);
            }
            else
            {
                uberResponse.Error = JsonConvert.DeserializeObject<UberError>(responseContent);
            }

            return uberResponse;
        }

        private async Task<UberResponse<T>> PostAsync<T>(string url, HttpContent content)
        {
            var uberResponse = new UberResponse<T>();

            var response = await _httpClient
                .PostAsync(url, content)
                .ConfigureAwait(false);

            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                uberResponse.Data = JsonConvert.DeserializeObject<T>(responseContent);
            }
            else
            {
                uberResponse.Error = JsonConvert.DeserializeObject<UberError>(responseContent);
            }

            return uberResponse;
        }

        private async Task<UberResponse<bool>> DeleteAsync(string url)
        {
            var uberResponse = new UberResponse<bool>();

            var response = await _httpClient
                .DeleteAsync(url)
                .ConfigureAwait(false);

            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                uberResponse.Data = true;
            }
            else
            {
                uberResponse.Error = JsonConvert.DeserializeObject<UberError>(responseContent);
            }

            return uberResponse;
        }

    }
}
