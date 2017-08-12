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

        // not null if this was fetched froh the API (not from the cache)
        public DateTime? FetchUtc { get; set; }

        // next time the API will be available to respond (in 10 minutes for a free account)
        public DateTime AvailableFetchUtc { get; set; }

        public string AvailableFetchStr
        {
            get
            {
                var now = DateTime.UtcNow;
                if (AvailableFetchUtc > now)
                {
                    var span = AvailableFetchUtc - now;
                    return string.Format("in {0} minutes {1} seconds", span.Minutes, span.Seconds);
                }
                else
                {
                    return "now";
                }
            }
        }

        #endregion
    }

    public class OwMain
    {
        #region Json

        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }

        #endregion

        #region MyRegion

        public string TempStr
        {
            get
            {
                return (int)(temp - 273.15) + " °C";
            }
        }

        #endregion
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

        public DayOfWeek DayOfWeek
        {
            get
            {
                return UnixDt.DayOfWeek;
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
