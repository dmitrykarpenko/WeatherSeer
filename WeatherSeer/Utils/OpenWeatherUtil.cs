using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherSeer.Dtos;

namespace WeatherSeer.Utils
{
    public static class OpenWeatherUtil
    {
        #region Const

        // "The cities' IDs can be found in the following file: http://bulk.openweathermap.org/sample/city.list.json.gz ..."
        // from which the example cities are taken
        private const string citiesJson = @"
            [
              {
                'id': 707860,
                'name': 'Hurzuf',
                'country': 'UA',
                'coord': {
                  'lon': 34.283333,
                  'lat': 44.549999
                }
              },
              {
                'id': 519188,
                'name': 'Novinki',
                'country': 'RU',
                'coord': {
                  'lon': 37.666668,
                  'lat': 55.683334
                }
              },
              {
                'id': 1283378,
                'name': 'Gorkhā',
                'country': 'NP',
                'coord': {
                  'lon': 84.633331,
                  'lat': 28
                }
              },
              {
                'id': 1270260,
                'name': 'State of Haryāna',
                'country': 'IN',
                'coord': {
                  'lon': 76,
                  'lat': 29
                }
              },
              {
                'id': 708546,
                'name': 'Holubynka',
                'country': 'UA',
                'coord': {
                  'lon': 33.900002,
                  'lat': 44.599998
                }
              },
              {
                'id': 703448,
                'name': 'Kiev',
                'country': 'UA',
                'coord': {
                  'lon': 30.516666,
                  'lat': 50.433334
                }
              },
            ]
        ";

        #endregion

        private static IEnumerable<OwCity> cities = null;
        public static IEnumerable<OwCity> GetCities()
        {
            return cities ?? (cities = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<OwCity>>(citiesJson));
        }
    }
}
