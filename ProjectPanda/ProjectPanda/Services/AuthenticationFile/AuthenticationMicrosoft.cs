using System;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Auth;
using System.Threading.Tasks;

namespace ProjectPanda.Services
{
     public class AuthenticationMicrosoft
    {
        Account account;
        AccountStore store;

        public void MicrosoftAuthFunction()
        {

            store = AccountStore.Create();
            account = store.FindAccountsForService(serviceId: "ddf910c8-6f98-4586-b26e-7b2e06f612a1").FirstOrDefault();

        }




        public void OnLoginClicked()
        {
            string clientId = null;
            string redirectUri = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    clientId = "ddf910c8-6f98-4586-b26e-7b2e06f612a1";
                    redirectUri = "https://projectpanda.azurewebsites.net/.auth/login/microsoftaccount/callback";
                    break;

                case Device.Android:
                    clientId = "ddf910c8-6f98-4586-b26e-7b2e06f612a1";
                    redirectUri = "https://projectpanda.azurewebsites.net/.auth/login/microsoftaccount/callback";
                    break;
            }

            OAuth2Authenticator authenticator = new OAuth2Authenticator(
              "ddf910c8-6f98-4586-b26e-7b2e06f612a1",
              null,
              "wl.basic",
              new Uri("http://projectpanda.azurewebsites.net/.auth/login/microsoftaccount"),
              new Uri("https://projectpanda.azurewebsites.net/.auth/login/microsoftaccount/callback"),
              new Uri("http://projectpanda.azurewebsites.net"),
              null,
              true);

            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;

            AuthenticationState.Authenticator = authenticator;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(authenticator);
        }



        async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            User user = null;
            if (e.IsAuthenticated)
            {
                // If the user is authenticated, request their basic user data from Google
                // UserInfoUrl = https://projectpanda.azurewebsites.net.azurewebsites.net/.auth/login/microsoftaccount/callback
                var request = new OAuth2Request("GET", new Uri("http://projectpanda.azurewebsites.net"), null, e.Account);
                var response = await request.GetResponseAsync();
                if (response != null)
                {
                    // Deserialize the data and store it in the account store
                    // The users email address will be used to identify data in SimpleDB
                    string userJson = await response.GetResponseTextAsync();
                    user = JsonConvert.DeserializeObject<User>(userJson);
                }

                if (account != null)
                {
                    store.Delete(account, serviceId: "ddf910c8-6f98-4586-b26e-7b2e06f612a1");
                }

                await store.SaveAsync(account = e.Account, serviceId: "ddf910c8-6f98-4586-b26e-7b2e06f612a1");
                await DisplayAlert("Email address", "Microsoft", cancel: "OK");
            }


        }

        private Task DisplayAlert(string v1, string v2, string cancel)
        {
            throw new NotImplementedException();
        }

        void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            Debug.WriteLine("Authentication error: " + e.Message);
        }

        private class AuthenticationState
        {
            public static OAuth2Authenticator Authenticator { get; internal set; }
        }

        private class User
        {
            internal string ToString(string v, string cancel)
            {
                throw new NotImplementedException();
            }
        }

    }
}
