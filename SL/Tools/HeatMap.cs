using Geocoding;
using Geocoding.Google;


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Tools
{
    public class HeatMap
    {

        public async void GetLatLng(string dirección)
        {

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyBvXWOz7cmL_ZcozvpJTMse3mbrYn6wBBg" };
            IEnumerable<Address> addresses = await geocoder.GeocodeAsync("2354 Los Platanos Villa Adelina Buenos Aires");
            var formattedAdress = ("Formatted: " + addresses.First().FormattedAddress);
            var latitudes = ("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude); 

            var test = formattedAdress + latitudes;
        }
    }
}
