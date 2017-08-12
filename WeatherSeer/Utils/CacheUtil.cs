using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherSeer.Dtos;

namespace WeatherSeer.Utils
{
    public static class CacheUtil
    {
        private static Dictionary<int, OwForecast> forecasts;

        private static readonly ReaderWriterLockSlim cacheLock;

        static CacheUtil()
        {
            forecasts = new Dictionary<int, OwForecast>();
            cacheLock = new ReaderWriterLockSlim();
        }

        public static OwForecast GetForecast(int owCityId)
        {
            cacheLock.EnterReadLock();
            try
            {
                OwForecast forecast = forecasts.TryGetValue(owCityId, out forecast) ? forecast : null;
                return forecast;
            }
            finally
            {
                cacheLock.ExitReadLock();
            }
        }

        public static void SaveForecast(OwForecast forecast)
        {
            if (forecast == null || forecast.list == null || !forecast.list.Any())
            {
                return;
            }

            cacheLock.EnterWriteLock();
            try
            {

                forecast.list = forecast.list.OrderByDescending(x => x.dt).ToList();
                var minDt = forecast.list.Last().dt;

                OwForecast cachedForecast = forecasts.TryGetValue(forecast.city.id, out cachedForecast) ? cachedForecast : null;

                if (cachedForecast != null)
                {
                    cachedForecast.list = cachedForecast.list.Where(x => x.dt < minDt).ToList();

                    // add two ordered collections - get ordered as a result
                    forecast.list.AddRange(cachedForecast.list);
                }

                var now = DateTime.UtcNow;
                forecast.list = forecast.list.Where(x => x.UnixDt > now).ToList();

                forecasts[forecast.city.id] = forecast;
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }

        public static DateTime? GetLastFetchUtc()
        {
            return forecasts.Any() ? forecasts.Min(x => x.Value.FetchUtc) : (DateTime?)null;
        }
    }
}
