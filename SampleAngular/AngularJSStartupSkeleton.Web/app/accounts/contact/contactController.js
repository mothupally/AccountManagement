(function () {
    "use strict";

    define([], function () {

        var contactController = function ($scope, $http) {
            $scope.message = "This is contact page.";
        };

        return ["$scope", "$http", contactController];

    });

})();