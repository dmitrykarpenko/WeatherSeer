using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherSeer.Logic;
using WeatherSeer.Utils;

namespace WeatherSeer.Controllers
{
    public class ForecastController : Controller
    {
        private ForecastLogic forecastLogic;

        public ForecastController()
        {
            forecastLogic = new ForecastLogic();
        }

        public ActionResult GetForecastPageData(int? owCityId)
        {
            var forecast = forecastLogic.GetForecastPageData(owCityId);
            return Json(forecast, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCityOptions()
        {
            var options = OpenWeatherUtil.GetCities();
            return Json(options, JsonRequestBehavior.AllowGet);
        }
    }
}