using ProjectPanda.Services.UberRide.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.Services.UberRide
{
     public interface IUberAuthenticationClient
    {
        #region Summary
        /// <summary>
        /// Generates an Uber OAuth authorization URL based on scopes, state and redirect.
        /// </summary>
        /// <param name="scopes">
        /// The permission scope/s being requested.
        /// </param>
        /// <param name="state">
        /// State which will be passed back to you to prevent tampering.
        /// </param>
        /// <param name="redirectUri">
        /// The URI we will redirect back to after an authorization by the resource owner.
        /// </param>
        /// <returns>
        /// Returns the OAuth authorization URL.
        /// </returns>
        #endregion
        string GetAuthorizeUrl(List<string> scopes = null, string state = null, string redirectUri = null);

        #region Authorization Summery 
        /// <summary>
        /// Exchange this authorization code for an AccessToken, allowing requests to be mande on behalf of a user.
        /// </summary>
        /// <param name="authorizationCode">
        /// The authorization code.
        /// </param>
        /// <param name="redirectUri">
        /// The URI the user should be redrected back to 
        /// </param>
        /// <returns>
        /// Returns an <see cref="AccessToken"/>.
        /// </returns>
        #endregion
        Task<AccessToken> GetAccessTokenAsync(string authorizationCode, string redirectUri);

        #region Revokation Summery
        /// <summary>
        /// Revoke a user's access to the Uber API via the application.
        /// </summary>
        /// <param name="accessToken">
        /// The access token being revoked.
        /// </param>
        /// <returns>
        /// Returns a boolean indicating if the Uber API returned a successful HTTP status.
        /// </returns>
        #endregion
        Task<bool> RevokeAccessTokenAsync(string accessToken);

        #region Refresh Access  Summary 
        /// <summary>
        /// Exchange this authorization code for an AccessToken, allowing requests to be mande on behalf of a user.
        /// </summary>
        /// <param name="refreshToken">
        /// The refresh token.
        /// </param>
        /// <param name="redirectUri">
        /// The URI the user should be redrected back to 
        /// </param>
        /// <returns>
        /// Returns an <see cref="AccessToken"/>.
        /// </returns>
        #endregion

        Task<AccessToken> RefreshAccessTokenAsync(string refreshToken, string redirectUri);

    }
}
