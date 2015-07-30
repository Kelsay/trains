angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {
        $stateProvider.state("home", {
            url: "/",
            templateUrl: "build/templates/home.html"
        });
    }]);