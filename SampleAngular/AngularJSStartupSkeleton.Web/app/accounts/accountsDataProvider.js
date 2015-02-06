(function () {
    "use strict";
    define([], function () {
        var accountsDataProvider = function ($resource) {
            var factory = {};
            var accountsDataRepository = $resource("/api/accounts", {}, {
                'userSignUp': {
                    method: 'POST',
                    url: "/api/accounts/signup",
                    transformRequest: function (data, headersGetter) {
                        var result = JSON.stringify(data);
                        return result;
                    }
                }
            });

            factory.userSignUp = function (data) {
                return accountsDataRepository.userSignUp(data);
            };

            return factory;
        };

        return ["$resource", accountsDataProvider];
    });
}());