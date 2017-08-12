'use strict';

weatherSeerApp.directive('forecastPage', // would be translated into snake-case tag name (forecast-page)
    function () {
        return {
            restrict: 'E',
            templateUrl: 'app/ForecastPage/fpTemplate.html'
        };
    });