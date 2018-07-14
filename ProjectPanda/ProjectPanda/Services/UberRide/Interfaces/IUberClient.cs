using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Services.UberRide.Model;

namespace ProjectPanda.Services.UberRide.Interfaces
{
    public interface IUberClient
    {
        #region Summery
        /// <summary>
        /// Gets the products available at a given location.
        /// </summary>
        /// <param name="latitude">
        /// The location latitude.
        /// </param>
        /// <param name="longitude">
        /// The location longitude.
        /// </param>
        /// <returns>
        /// Returns a <see cref="ProductCollection"/>.
        /// </returns>
        #endregion
        Task<UberResponse<ProductCollection>> GetProductsAsync(float latitude, float longitude);

        #region Summary
        /// <summary>
        /// Gets an estimated price range for each product available at a given location.
        /// </summary>
        /// <param name="startLatitude">
        /// The start location latitude.
        /// </param>
        /// <param name="startLongitude">
        /// The start location longitude.
        /// </param>
        /// <param name="endLatitude">
        /// The end location latitude.
        /// </param>
        /// <param name="endLongitude">
        /// The end location longitude.
        /// </param>
        /// <returns>
        /// Returns a <see cref="PriceEstimateCollection"/>.
        /// </returns>
        #endregion
        Task<UberResponse<PriceEstimateCollection>> GetPriceEstimateAsync(float startLatitude, float startLongitude, float endLatitude, float endLongitude);

        #region Summary
        /// <summary>
        /// Gets an ETA for each product available at a given location.
        /// </summary>
        /// <param name="startLatitude">
        /// The start location latitude.
        /// </param>
        /// <param name="startLongitude">
        /// The start location longitude.
        /// </param>
        /// <param name="customerId">
        /// Optional customer ID. Uber documentation describes as a "Unique customer identifier to be used for experience customization."
        /// </param>
        /// <param name="productId">
        /// Optional product ID to filter results.
        /// </param>
        /// <returns>
        /// Returns a <see cref="TimeEstimateCollection"/>.
        /// </returns>
        #endregion
        Task<UberResponse<TimeEstimateCollection>> GetTimeEstimateAsync(float startLatitude, float startLongitude, string customerId, string productId);

        #region Summary
        /// <summary>
        /// Gets a promotion available to new users based on location.
        /// </summary>
        /// <param name="startLatitude">
        /// The start location latitude.
        /// </param>
        /// <param name="startLongitude">
        /// The start location longitude.
        /// </param>
        /// <param name="endLatitude">
        /// The end location latitude.
        /// </param>
        /// <param name="endLongitude">
        /// The end location longitude.
        /// </param>
        /// <returns>
        /// Returns a <see cref="Promotion"/>.
        /// </returns>
        #endregion
        Task<UberResponse<Promotion>> GetPromotionAsync(float startLatitude, float startLongitude, float endLatitude, float endLongitude);

        #region Summary
        /// <summary>
        /// Gets a list of the user's Uber activity.
        /// </summary>
        /// <param name="offset">
        /// The results offset.
        /// </param>
        /// <param name="limit">
        /// The results limit.
        /// </param>
        /// <returns>
        /// Returns a <see cref="UserActivity"/>.
        /// </returns>
        /// 
#endregion
        Task<UberResponse<UserActivity>> GetUserActivityAsync(int offset, int limit);

        #region Summary
        /// <summary>
        /// Gets the user's Uber profile.
        /// </summary>
        /// <returns>
        /// Returns a <see cref="UserProfile"/>.
        /// </returns>
        #endregion
        Task<UberResponse<UserProfile>> GetUserProfileAsync();

        #region Summary
        /// <summary>
        /// Makes a pickup request.
        /// </summary>
        /// <param name="productId">
        /// The product ID.
        /// </param>
        /// <param name="startLatitude">
        /// The start location latitude.
        /// </param>
        /// <param name="startLongitude">
        /// The start location longitude.
        /// </param>
        /// <param name="endLatitude">
        /// The end location latitude.
        /// </param>
        /// <param name="endLongitude">
        /// The end location longitude.
        /// </param>
        /// <param name="surgeConfirmationId">
        /// The surge pricing confirmation ID.
        /// </param>
        /// <returns>
        /// Returns a <see cref="Request"/>.
        /// </returns>
        /// 
        #endregion
        Task<UberResponse<Request>> RequestAsync(string productId, float startLatitude, float startLongitude, float endLatitude, float endLongitude, string surgeConfirmationId = null);

        #region Summary
        /// <summary>
        /// Gets a request details.
        /// </summary>
        /// <param name="requestId">
        /// The request ID.
        /// </param>
        /// <returns>
        /// Returns a <see cref="RequestDetails"/>.
        /// </returns>
        /// 
        #endregion
        Task<UberResponse<RequestDetails>> GetRequestDetailsAsync(string requestId);

        #region Summary
        /// <summary>
        /// Gets the map for a given request.
        /// </summary>
        /// <param name="requestId">
        /// The request ID.
        /// </param>
        /// <returns>
        /// Returns a <see cref="RequestMap"/>.
        /// </returns>
        #endregion
        Task<UberResponse<RequestMap>> GetRequestMapAsync(string requestId);

        #region Summary
        /// <summary>
        /// Cancels a given request.
        /// </summary>
        /// <param name="requestId">
        /// The request ID.
        /// </param>
        /// <returns>
        /// Returns a boolean indicating if the Uber API returned a successful HTTP status.
        /// </returns>
        /// 
        #endregion
        Task<UberResponse<bool>> CancelRequestAsync(string requestId);
    }
}
