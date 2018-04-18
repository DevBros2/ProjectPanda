using System;
using Xamarin.Forms;
using ProjectPanda;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Xamarin.Auth;
using Newtonsoft.Json.Linq;

[assembly: ExportRenderer (typeof (Login), typeof (FBLoginTeste.Droid.LoginPageRenderer))]

namespace FBLoginTeste.Droid
{
	public class LoginPageRenderer : PageRenderer
	{

		public LoginPageRenderer()
		{
			var activity = this.Context as Activity;

			var auth = new OAuth2Authenticator (
				clientId: "136133043698809", // KHANYISANI  please double check this value
				scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
				authorizeUrl: new Uri ("https://m.facebook.com/dialog/oauth/"),
				redirectUrl: new Uri ("https://projectpanda.azurewebsites.net/.auth/login/facebook/callback"));

			auth.Completed += async (sender, eventArgs) => {
				if (eventArgs.IsAuthenticated) {
					var accessToken = eventArgs.Account.Properties ["access_token"].ToString ();
					var expiresIn = Convert.ToDouble (eventArgs.Account.Properties ["expires_in"]);
					var expiryDate = DateTime.Now + TimeSpan.FromSeconds (expiresIn);

					var request = new OAuth2Request ("GET", new Uri ("https://graph.facebook.com/me"), null, eventArgs.Account);
					var response = await request.GetResponseAsync ();
					var obj = JObject.Parse (response.GetResponseText ());

					var id = obj ["id"].ToString ().Replace ("\"", ""); 
					var name = obj ["name"].ToString ().Replace ("\"", "");

					App.NavigateToProfile(string.Format("Sawubona {0}", name));
				} else {
					App.NavigateToProfile("We Couldnt Log you in :( ");
				}
			};

			activity.StartActivity (auth.GetUI(activity));	// returns the UI
		}
	}
}
