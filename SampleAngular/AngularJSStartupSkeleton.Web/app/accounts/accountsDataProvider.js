(function () {
    "use strict";
    define([], function () {
        var accountsDataProvider = function ($resource) {
            var factory = {};
            var accountsDataRepository = $resource("/api/accounts", {}, {
                'getUser': { method: 'GET', url: "/api/accounts/user/:requestGuid" },
                'getUsers': { method: 'GET', url: "/api/accounts/user" },
                'getContacts': { method: 'GET', url: "/api/accounts/contact" },

                'userSignUp': {
                    method: 'POST',
                    url: "/api/accounts/signup",
                    transformRequest: function (data, headersGetter) {
                        var result = JSON.stringify(data);
                        return result;
                    }
                },
                'userLogin': {
                    method: 'POST',
                    url: "/api/accounts/login",
                    transformRequest: function (data, headersGetter) {
                        var result = JSON.stringify(data);
                        return result;
                    }
                },
                'userSettings': {
                    method: 'POST',
                    url: "/api/accounts/settings",
                    transformRequest: function (data, headersGetter) {
                        var result = JSON.stringify(data);
                        return result;
                    }
                },
                'userContact': {
                    method: 'POST',
                    url: "/api/accounts/contact",
                    transformRequest: function (data, headersGetter) {
                        var result = JSON.stringify(data);
                        return result;
                    }
                }
            });
            factory.getContacts = function (params) {
                return accountsDataRepository.getContact(params);
            };
            factory.getUser = function (params) {
                return accountsDataRepository.getUser(params);
            };
            factory.getUsers = function (params) {
                return accountsDataRepository.getUsers(params);
            };

            factory.userSignUp = function (data) {
                return accountsDataRepository.userSignUp(data);
            };
            factory.userLogin = function (data) {
                return accountsDataRepository.userLogin(data);
            };
            factory.userSettings = function (data) {
                return accountsDataRepository.userSettings(data);
            };
            factory.userContact = function (data) {
                return accountsDataRepository.userContact(data);
            };

            return factory;
        };

        return ["$resource", accountsDataProvider];
    });
}());