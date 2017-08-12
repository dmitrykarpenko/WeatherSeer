'use strict';

weatherSeerApp.factory('fpService',
    ["$http", function fpService($http) {
        function getForecast(owCityId) {
            return $http.get('/Forecast/GetForecastPageData?owCityId='+owCityId);
        }
        function getCityOptions() {
            return $http.get('/Forecast/GetCityOptions');
        }
        return {
            getForecast: getForecast,
            getCityOptions: getCityOptions,
        }
    }]);