(function () {
    "use strict";

    define([], function () {

        var signupController = function ($scope, $http) {

            // function to submit the form after all validation has occurred			
            $scope.submitForm = function () {

                // Set the 'submitted' flag to true
                $scope.submitted = true;

                if ($scope.userForm.$valid) {
                    alert("Form is valid!");
                }
                else {
                    alert("Please correct errors!");
                }
            };
        };

        return ["$scope", "$http", signupController];

    });

})();