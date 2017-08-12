using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WeatherSeer.Dtos;
using WeatherSeer.Utils;

// Logic namespace could be moved to lower architecture layer (logic layer) and injected to controllers with an interface
namespace WeatherSeer.Logic
{
    public class ForecastLogic
    {
        private string apiUrlTemplate;
        private HttpClient httpClient;

        public ForecastLogic()
        {
            apiUrlTemplate = "http://api.openweathermap.org/data/2.5/forecast?id={0}&APPID=ebe51a5d907afeaee540deb6ad3a5163";
            httpClient = new HttpClient();
        }

        public OwForecast GetForecastPageData(int owCityId)
        {
            OwForecast owForecast = null;

            var lastFetchUtc = CacheUtil.GetLastFetchUtc();
            if (!lastFetchUtc.HasValue || lastFetchUtc.Value < DateTime.UtcNow.AddMinutes(-10))
            {
                var apiUrl = string.Format(apiUrlTemplate, owCityId);
                var result = httpClient.GetAsync(apiUrl).Result;

                if (result.IsSuccessStatusCode)
                {
                    var resultString = result.Content.ReadAsStringAsync().Result;
                    owForecast = JsonConvert.DeserializeObject<OwForecast>(resultString);

                    owForecast.FetchUtc = DateTime.UtcNow;

                    CacheUtil.SaveForecast(owForecast);
                }
            }
            else
            {
                owForecast = CacheUtil.GetForecast(owCityId);
            }

            if (owForecast != null)
            {
                owForecast.CityOptions = OpenWeatherUtil.GetCities();
            }

            return owForecast;
        }
    }
}
