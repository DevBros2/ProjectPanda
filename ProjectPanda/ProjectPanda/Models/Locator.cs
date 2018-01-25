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

            string userLat = postion.Latitude.ToString();

            string userLongi = postion.Longitude.ToString();

        }


    }
}
