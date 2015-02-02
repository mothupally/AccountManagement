(function () {
    "use strict";

    define([], function () {

        var homeController = function ($scope, $http) {
            $scope.message = "This is home page.";
        };

        return ["$scope", "$http", homeController];

    });

})();