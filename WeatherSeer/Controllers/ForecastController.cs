using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherSeer.Logic;

namespace WeatherSeer.Controllers
{
    public class ForecastController : Controller
    {
        private ForecastLogic forecastLogic;

        public ForecastController()
        {
            forecastLogic = new ForecastLogic();
        }

        public ActionResult GetForecastPageData(int owCityId)
        {
            var forecast = forecastLogic.GetForecastPageData(owCityId);
            return Json(forecast, JsonRequestBehavior.AllowGet);
        }
    }
}