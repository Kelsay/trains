angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {

        $stateProvider.state("article", {
            url: "/article/:alias",
            templateUrl: "app/components/articles/article.html",
            controller: "ArticleController",
            params: {
                id: '',
                alias: ''
            }
        });

    }])

.controller("ArticleController",
    ['$scope', 'Restangular','$stateParams', function ($scope, Restangular,$stateParams) {

        $scope.article = Restangular.one("articles", $stateParams.id).get().$object;

}]);