angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {

        $stateProvider.state('trains', {
            url: "/trains",
            templateUrl: "app/components/trains/trains.html",
            controller: "TrainsController"
        });

    }])


/*
.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when("/trains", {
        templateUrl: "app/components/trains/trains.html",
        controller: "TrainsController"
    })
}]) */
.controller('TrainsController',['$scope','Restangular',function ($scope,Restangular) {

    $scope.hello = "Hello World. And scope.";

    $scope.trains = Restangular.all("trains").getList().$object;

    console.log(Restangular.all("trains").getList());


}]);