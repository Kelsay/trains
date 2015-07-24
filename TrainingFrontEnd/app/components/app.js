'use strict';
// The Main Application module

var app = angular.module('Trains', ['ngRoute', 'ngAnimate', 'restangular', 'ui.router'])

.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'build/templates/home.html',
        })
    .otherwise({ redirectTo: '/home' });

    $locationProvider.html5Mode(true);
}])

// Restangular Configuration

.config(['RestangularProvider', function (RestangularProvider) {

    RestangularProvider.setBaseUrl("http://api.training.com");
    
}]);