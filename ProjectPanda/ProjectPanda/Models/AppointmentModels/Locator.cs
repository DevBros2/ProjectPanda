using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Geolocator.Abstractions;
using Plugin.Geolocator;
using Plugin.Permissions.Abstractions;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace ProjectPanda.Models
{
    public class Locator
    {
        
        public async Task GetCurrentLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 5;
            var postion = await locator.GetPositionAsync(TimeSpan.FromMilliseconds(100000));

            double userLat = postion.Latitude;

            double userLongi = postion.Longitude;


            void SendLatCordinates()
            {
                GetLatitude(userLat);
            }

            void SendLongitudeCoordinates()
            {
                GetLongitude(userLongi);
            }

            #region Try catch-finally region-might have to come and revist this block cause I am not sure how I will use it-khanyisani

            try
            {
                // GetLatitude(userLat);

                //  GetLongitude(userLongi);


            }

            catch (Exception postionChangingStandStill)
            {
                //Rather a pop up to say the user is moving too much
                postionChangingStandStill.ToString();
            }

            finally
            {

            }

            #endregion



        }


        //the user Latitude
        private double GetLatitude(double userLatitudeLocation)
        {
            return userLatitudeLocation;
        }

        //the user Longitude
        private double GetLongitude(double userLongitudeLocation)
        {
            return userLongitudeLocation;
        }

        
    }
}
