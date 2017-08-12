'use strict';

weatherSeerApp.controller('fpController',
    function fpController($scope, fpService) {
        $scope.forecast = fpService.forecast;
    });