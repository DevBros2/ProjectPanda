using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Geolocator;
using System.Threading.Tasks;
namespace ProjectPanda.Models
{
    public class DistanceCalculator:Locator
    {
        #region Calculates the radians of the degree 
        //the c# libaray does not allow you to have parameters as degrees and radians are more accurate
         public  static  double toRadians(double angle)
        {
            return  Math.PI * angle / 180.0;
        }

        #endregion


       
       


    
        #region distance calculator 
        //method for calulating distance between user and location
        public double DistanceCalculating(double latitude1, double latitude2, double longitude1, double longitude2)
        {
            /*
                latitude1 and longitude1-user current location 
                
                latitude2 and longitude2-practice location

                 L1 and L2 will be taken from the gpslocator class
             
             */

            const double kilo = 6372.8; //in kilometeres this the radius of the earth

            var lat = toRadians(latitude2 - latitude1); //converts the cordinates to radians 
            var longi = toRadians(longitude2 - longitude1); //converts the cordinates to radians 

            latitude1 = toRadians(latitude1);
            latitude2 = toRadians(latitude2);

            var a = (Math.Sin(lat / 2) * Math.Sin(lat / 2)) + (Math.Sin(longi / 2) * Math.Sin(longi / 2) * Math.Cos(latitude1) * Math.Cos(latitude2)); //calculates the distance I think from the formula I worked out 2rarcsin

            var c = 2 * Math.Asin(Math.Sqrt(a));

            /*
                var userLat=latitude1;
                var userLong=longitude1

              */

            return kilo * 2 * Math.Asin(Math.Sqrt(a));




        }
        #endregion



        public async Task GetCurrentLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 5;
            var postion = await locator.GetPositionAsync(TimeSpan.FromMilliseconds(100000));

            double userLat = postion.Latitude;

            double userLongi = postion.Longitude;

            DistanceCalculating(userLat, 56.67, userLongi, 563.5);
     
        }



    }
}
