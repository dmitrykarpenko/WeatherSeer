'use strict';

weatherSeerApp.controller('fpController',
    ['$scope', '$timeout', 'fpService', function fpController($scope, $timeout, fpService) {
        $scope.getForecast = function (owCityId) {
            fpService.getForecast(owCityId)
                .then(function (result) {
                    $scope.forecast = result.data;
                });
        };
        $scope.getForecast();

        fpService.getCityOptions()
            .then(function (result) {
                $scope.cityOptions = result.data;
            });
    }]);