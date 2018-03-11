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

        
    
        protected async Task GetCurrentLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 5;
            var postion = await locator.GetPositionAsync(TimeSpan.FromMilliseconds(100000));

            double userLat = postion.Latitude;

            double userLongi = postion.Longitude;

            #region Try catch-finally region
            try
            { 
                //if(moving to much then display a pop up with a message to ask user to stop moving too much to get location for)
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


    }
}
