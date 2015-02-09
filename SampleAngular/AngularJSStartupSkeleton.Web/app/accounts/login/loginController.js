(function () {
    "use strict";

    define([], function () {

        var loginController = function ($scope, $http, $rootScope, $location, accountsDataProvider) {
            $scope.message = "This is login page.";

            $scope.submitForm = function () {
                var account = {
                    EmailAddress: $scope.user.EmailAddress,
                    Password: $scope.user.Password,
                    Id: '',
                    UserName: ''
                };
                accountsDataProvider.userLogin(account).$promise.then(function (data) {
                    if (data.userId != undefined) {
                        $rootScope.$broadcast('loginSuccess', true);
                        $rootScope.currentUser = data;
                        $location.path('/settings');
                    }
                    else {
                        $scope.loginSuccess = false;
                    }
                });
            }

            var initialize = function () {
                $scope.loginSuccess = true;
            }

            initialize();
        };

        return ["$scope", "$http", "$rootScope", "$location", "accountsDataProvider", loginController];

    });

})();