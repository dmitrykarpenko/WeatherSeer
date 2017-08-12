﻿using System;
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
            ]
        ";

        #endregion

        public static IEnumerable<OwCity> GetCities()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<OwCity>>(citiesJson);
        }
    }
}
