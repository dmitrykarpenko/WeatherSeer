using System;
using System.Collections.Generic;

// Logic namespace could be moved to lower architecture layer (logic layer)
namespace WeatherSeer.Dtos
{
    // Ow stands for OpenWeather http://openweathermap.org/appid
    public class OwForecast
    {
        // properties in this region would be mapped from JSON
        #region Json

        //public string cod { get; set; }
        //public double message { get; set; }
        //public int cnt { get; set; }
        public List<OwListItem> list { get; set; }
        public OwCity city { get; set; }

        #endregion

        #region Custom

        public DateTime FetchUtc { get; set; }

        public IEnumerable<OwCity> CityOptions { get; set; }

        #endregion
    }

    public class OwMain
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class OwWeather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class OwClouds
    {
        public int all { get; set; }
    }

    public class OwWind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class OwSnow
    {
        //public double? 3h { get; set; }
    }

    public class OwSys
    {
        public string pod { get; set; }
    }

    public class OwListItem
    {
        #region Json

        public int dt { get; set; }
        public OwMain main { get; set; }
        public List<OwWeather> weather { get; set; }
        public OwClouds clouds { get; set; }
        public OwWind wind { get; set; }
        public OwSnow snow { get; set; }
        public OwSys sys { get; set; }
        public string dt_txt { get; set; }

        #endregion

        #region Custom

        public DateTime UnixDt
        {
            get
            {
                return new DateTime(1970, 1, 1).AddSeconds(dt);
            }
        }

        #endregion
    }

    public class OwCoord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class OwCity
    {
        public int id { get; set; }
        public string name { get; set; }
        public OwCoord coord { get; set; }
        public string country { get; set; }
    }
}
