(function () {
    "use strict";

    define([], function () {

        var contactController = function ($scope, $http, accountsDataProvider) {
            $scope.message = "This is contact page.";

            $scope.submitForm = function () {
                accountsDataProvider.userContact($scope.userContacts).$promise.then(function (data) {
                    $scope.contactCreated = false;
                });
            }

            var initialize = function () {
                $scope.contactCreated = true;
            }

            initialize();
        };
        return ["$scope", "$http", "accountsDataProvider", contactController];
    });
})();