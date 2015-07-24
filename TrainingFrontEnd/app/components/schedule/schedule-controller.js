angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {

        $stateProvider.state("stations", {
            url: "/stations",
            templateUrl: "build/templates/stations.html",
            controller: "StationsController"
        })

        .state("station", {
            url: "/stations/:id/",
            templateUrl: "build/templates/station.html",
            controller: "StationController"
        })

    }])


    // Station list - controller 

.controller("StationsController",
    ['$scope', 'Restangular', function ($scope, Restangular) {

        var stations = Restangular.all("stations");
        $scope.stations = stations.getList().$object;
        $scope.sortBy = "name";

        $scope.order = function (sortBy) {
            $scope.sortBy = sortBy;
        }

    }])


.controller("StationController",
    ['$scope', 'Restangular', '$stateParams', function ($scope, Restangular, $stateParams) {

        var stations = Restangular.all("stations");
        var id = $stateParams.id;
        $scope.station = stations.one(id).get().$object;


    }]);