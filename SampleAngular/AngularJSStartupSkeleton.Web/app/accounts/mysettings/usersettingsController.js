(function () {
    "use strict";

    define([], function () {

        var usersettingsController = function ($scope, $http, $rootScope, $location, accountsDataProvider) {

            $scope.submitForm = function () {
                accountsDataProvider.userSettings($scope.userDetails).$promise.then(function (data) {
                    $scope.accountUpdated = true;
                });
            }

            var initialize = function () {
                if (!angular.isUndefined($rootScope.currentUser) && $rootScope.currentUser != null) {
                    accountsDataProvider.getUser({ requestGuid: $rootScope.currentUser.userId }).$promise.then(function (data) {
                        $scope.userDetails = data;
                    });
                    $scope.accountUpdated = false;
                }
                else {
                    $location.path('/login');
                }
            }

            initialize();
        };

        return ["$scope", "$http", "$rootScope", "$location", "accountsDataProvider", usersettingsController];

    });

})();