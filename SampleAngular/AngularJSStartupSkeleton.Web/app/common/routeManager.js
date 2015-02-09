(function () {
    "use strict";
    define([], function () {
        var routeManager = function ($stateProvider) {
            $stateProvider
             .state(
                 "about", {
                     url: "/about",
                     templateUrl: "./app/accounts/about/about.html",
                     controller: "aboutController"
                 })
            .state(
                "home", {
                    url: "/home",
                    templateUrl: "./app/accounts/home/home.html",
                    controller: "homeController"
                })
            .state(
                "login", {
                    url: "/login",
                    templateUrl: "./app/accounts/login/login.html",
                    controller: "loginController"
                })
            .state(
                "forgot", {
                    url: "/login/forgot",
                    templateUrl: "./app/accounts/login/forgot.html",
                    controller: "loginController"
                })
            .state(
                "contact", {
                    url: "/contact",
                    templateUrl: "./app/accounts/contact/contact.html",
                    controller: "contactController"
                })
            .state(
                "settings", {
                    url: "/settings",
                    templateUrl: "./app/accounts/mysettings/usersettings.html",
                    controller: "usersettingsController"
                })
            .state(
                "signup", {
                    url: "/signup",
                    templateUrl: "./app/accounts/signup/signup.html",
                    controller: "signupController"
                })
        };
        return ['$stateProvider', routeManager];
    });
}());
