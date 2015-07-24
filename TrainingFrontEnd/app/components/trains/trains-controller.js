angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {

        $stateProvider
            .state('trains', {
                url: "/trains",
                templateUrl: "build/templates/trains.html",
                controller: "TrainsController"
            })
            .state('train', {
                url: "/trains/:id",
                templateUrl: "build/templates/train.html",
                controller: "TrainsController"
            });

    }])

    .controller('TrainsController', ['$scope', 'Restangular','$stateParams', function ($scope, Restangular, $stateParams) {

        var trains = Restangular.all('trains');
        var id = $stateParams.id;
        if (id) {
            $scope.train = trains.one(id).get().$object;
        } else {
            $scope.trains = trains.getList().$object;
        }      

    }]);