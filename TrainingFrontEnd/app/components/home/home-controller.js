angular.module("Trains")

    .config(['$stateProvider', function ($stateProvider) {
        $stateProvider.state("home", {
            url: "home/",
            templateUrl: "build/templates/home.html"
        });
    }]);