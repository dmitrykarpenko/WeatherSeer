'use strict';

weatherSeerApp.controller('fpController',
    ['$scope', 'fpService', function fpController($scope, fpService) {
        $scope.forecast = fpService.forecast;

        fpService.getForecast($scope.forecast.city.id)
            .then(function (result) {
                var data = result.data;
            });
    }]);