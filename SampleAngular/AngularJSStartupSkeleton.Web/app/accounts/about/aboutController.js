(function () {
    "use strict";

    define([], function () {

        var aboutController = function ($scope, $http) {
            $scope.message = "This is about page.";
        };

        return ["$scope", "$http", aboutController];

    });

})();