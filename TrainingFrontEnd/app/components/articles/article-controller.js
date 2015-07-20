angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {

        $stateProvider.state("article", {
            url: "/article/:id",
            templateUrl: "app/components/articles/article.html",
            controller: "ArticleController"
        });

    }])

.controller("ArticleController",
    ['$scope', 'Restangular','$stateParams', function ($scope, Restangular,$stateParams) {

        $scope.article = Restangular.one("articles", $stateParams.id).get().$object;

}]);