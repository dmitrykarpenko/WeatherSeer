'use strict';

weatherSeerApp.controller('fpController',
    ['$scope', 'fpService', function fpController($scope, fpService) {
        $scope.forecast = fpService.forecast;
    }]);