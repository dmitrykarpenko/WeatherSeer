'use strict';

weatherSeerApp.factory('fpService',
    ["$http", function fpService($http) {
        function getForecast(owCityId) {
            return $http.get(Context.GetForecastPageDataUrl + '?owCityId='+owCityId);
        }
        function getCityOptions() {
            return $http.get(Context.GetCityOptionsUrl);
        }
        return {
            getForecast: getForecast,
            getCityOptions: getCityOptions,
        }
    }]);