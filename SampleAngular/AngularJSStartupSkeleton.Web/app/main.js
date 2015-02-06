(function () {
    "use strict";

    require.config(
            {
                appDir: "",
                baseUrl: "./app",
            });

    require(["./common/routeManager",
            "./accounts/accountsModule",
            "./layout/layoutModule"
    ],
            function (routeManager,
                        accountsModule,
                        layoutModule
                    ) {
                var serviceBase = 'http://localhost:2693/';
                var ngAuthSettings = {
                    apiServiceBaseUri: serviceBase,
                    clientId: 'ngAuthApp'
                };

                var appName = "myApp";
                angular.module(
                                appName,
                                ["ngRoute",
                                "ngCookies",
                                "ui.router",
                                "ngResource",
                                accountsModule,
                                layoutModule
                                ])
                        .config(routeManager)
                        .constant(ngAuthSettings);
                angular.bootstrap(document.getElementsByTagName("body")[0], [appName]);
            });
}());