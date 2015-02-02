(function () {
    "use strict";

    define([], function () {

        var loginController = function ($scope, $http) {
            $scope.message = "This is login page.";
        };

        return ["$scope", "$http", loginController];

    });

})();