(function () {
    "use strict";

    define([], function () {

        var signupController = function ($scope, $http, accountsDataProvider) {
            // function to submit the form after all validation has occurred			

            $scope.submitForm = function () {
                if ($scope.userForm.$valid) {
                    
                    accountsDataProvider.userSignUp($scope.user).$promise.then(function (data) {
                        console.log(data);
                        $scope.accountCreated = false;
                    });

                }
                else {
                    alert("Please correct errors!");
                }
            };

            var initialize = function () {
                $scope.accountCreated = true;
            }

            initialize();
        };

        return ["$scope", "$http", "accountsDataProvider", signupController];

    });

})();