using System.Web.Mvc;
using WeatherSeer.Utils;

namespace WeatherSeer.Controllers
{
    public class HomeController : Controller
    {
        private Logic.ForecastLogic forecastLogic;

        public HomeController()
        {
            forecastLogic = new Logic.ForecastLogic();
        }

        #region Pages

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region Ajax

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

        #endregion
    }
}