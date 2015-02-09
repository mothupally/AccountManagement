(function () {
    define([], function () {
        var headerController = function ($scope, $rootScope, $location) {
            $scope.Branding = "Angular Application";
            $scope.loginSuccess = false;

            $scope.signOut = function () {
                $rootScope.currentUser = null;
                $scope.loginSuccess = false;
                $location.path('/login');
            }

            $scope.isActive = function (viewLocation) {
                var activePath = (viewLocation === $location.path());
                return activePath;
            };
            $scope.$on('loginSuccess', function (event, data) {
                $scope.isActive('/settings');
                $scope.loginSuccess = data;
            });
        };
        return ["$scope", "$rootScope", "$location", headerController];
    });
}());