angular.module("Trains")

.controller("MenuController",
    ['$scope', 'Restangular', function ($scope, Restangular) {

        $scope.articles = Restangular.all("articles").getList().$object;

}]);