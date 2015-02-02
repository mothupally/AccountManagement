(function () {
    "use strict";

    require.config(
            {
                appDir: "",
                baseUrl: "./app",
            });

    require(["./common/routeManager",
            "./accounts/home/homeModule",
            "./accounts/about/aboutModule",
            "./accounts/contact/contactModule",
            "./accounts/signup/signupModule",
            "./accounts/login/loginModule",
            "./layout/layoutModule"
    ],
            function (routeManager,
                        homeModule,
                        aboutModule,
                        contactModule,
                        signupModule,
                        loginModule,
                layoutModule
                    ) {
                var appName = "myApp";
                angular.module(
                                appName,
                                ["ngRoute",
                                "ngCookies",
                                "ui.router",
                                "ngResource",
                                homeModule,
                                aboutModule,
                                contactModule,
                                signupModule,
                                loginModule,
                                layoutModule
                                ])
                        .config(routeManager);
                angular.bootstrap(document.getElementsByTagName("body")[0], [appName]);
            });
}());