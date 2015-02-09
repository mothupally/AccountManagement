(function () {
    "use strict";

    define([], function () {

        var signupController = function ($scope, $http, accountsDataProvider) {
            // function to submit the form after all validation has occurred			

            $scope.submitForm = function () {
                if ($scope.userForm.$valid) {
                    accountsDataProvider.userSignUp($scope.user).$promise.then(function (data) {
                        if (data) {
                            $scope.accountCreated = false;
                        }
                        else {
                            $scope.accountExists = false;
                        }
                    });
                }
            };

            var initialize = function () {
                $scope.accountCreated = true;
                $scope.accountExists = true;
            }

            initialize();
        };

        return ["$scope", "$http", "accountsDataProvider", signupController];

    });

})();