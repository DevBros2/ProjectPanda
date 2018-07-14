using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using ProjectPanda.Services.UberRide.Model;

namespace ProjectPanda.Services.UberRide
{
    public class UberAuthenticationClient: IUberAuthenticationClient
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        public UberAuthenticationClient(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentException("Parameter is required", "clientId");
            if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentException("Parameter is required", "clientSecret");

            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<AccessToken> GetAccessTokenAsync(string authorizationCode, string redirectUri)
        {
            var data = new Dictionary<string, string>
            {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "grant_type", "authorization_code" },
                { "code", authorizationCode },
                { "redirect_uri", redirectUri }
            };

            return await AuthorizeAsync(data);
        }

        public string GetAuthorizeUrl(List<string> scopes = null, string state = null, string redirectUri = null)
        {
            var authorizeUrl = string.Concat("https://login.uber.com/oauth/authorize?response_type=code&client_id=", _clientId);

            if (scopes != null && scopes.Any())
            {
                authorizeUrl += string.Concat("&scope=", string.Join(" ", scopes));
            }

            if (!string.IsNullOrWhiteSpace(state))
            {
                authorizeUrl += string.Concat("&state=", state);
            }

            if (!string.IsNullOrWhiteSpace(redirectUri))
            {
                authorizeUrl += string.Concat("&redirect_uri=", HttpUtility.UrlEncode(redirectUri));
            }

            return authorizeUrl;
        }

        public async Task<bool> RevokeAccessTokenAsync(string accessToken)
        {
            var formData = new Dictionary<string, string>
            {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "token", accessToken }
            };

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient
                    .PostAsync("https://login.uber.com/oauth/revoke", new FormUrlEncodedContent(formData))
                    .ConfigureAwait(false);

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<AccessToken> RefreshAccessTokenAsync(string refreshToken, string redirectUri)
        {
            var data = new Dictionary<string, string>
            {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken },
                { "redirect_uri", redirectUri }
            };

            return await AuthorizeAsync(data);
        }


        private async Task<AccessToken> AuthorizeAsync(Dictionary<string, string> content)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient
                    .PostAsync("https://login.uber.com/oauth/token", new FormUrlEncodedContent(content))
                    .ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<AccessToken>(responseContent);
            }
        }

    }
}
