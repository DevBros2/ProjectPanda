using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using System.Diagnostics;
using Newtonsoft.Json;
using Xamarin.Forms;
using ProjectPanda.Pages;

namespace ProjectPanda.Services
{
     public class AuthenticationFacebook
    {



            Account account;
            AccountStore store;



            public void FacebookAuthFunction()
            {

                store = AccountStore.Create();
                account = store.FindAccountsForService(serviceId: "136133043698809").FirstOrDefault();

            }


            public void OnLoginClicked()
            {
                string clientId = null;
                string redirectUri = null;

                switch (Device.RuntimePlatform)
                {
                    case Device.iOS:
                        clientId = "136133043698809";
                        redirectUri = "https://projectpanda.azurewebsites.net/.auth/login/facebook/callback";
                        break;

                    case Device.Android:
                        clientId = "136133043698809";
                        redirectUri = "https://projectpanda.azurewebsites.net/.auth/login/facebook/callback";
                        break;
                }

                OAuth2Authenticator authenticator = new OAuth2Authenticator(
                  "136133043698809",
                  null,
                  "public_profile",
                  new Uri("https://m.facebook.com/dialog/oauth/"),
                  new Uri("https://projectpanda.azurewebsites.net/.auth/login/facebook/callback"),
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
                    // UserInfoUrl =
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
                        store.Delete(account, serviceId: "136133043698809");
                    }

                    await store.SaveAsync(account = e.Account, serviceId: "136133043698809");
                    await DisplayAlert("Email address", "Facebook", cancel: "OK");
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

