(function () {
    "use strict";

    define(["./contact/contactController", "./signup/signupController",
        "./login/loginController", "./about/aboutController",
        "./home/homeController", "./accountsDataProvider"],
        function (contactController, signupController,
            loginController, aboutController, homeController, accountsDataProvider) {

            var moduleName = "myApp.accountsModule";
            angular
                .module(moduleName, [])
                .controller("contactController", contactController)
                .controller("signupController", signupController)
                .controller("loginController", loginController)
                .controller("aboutController", aboutController)
                .controller("homeController", homeController)
                .factory("accountsDataProvider", accountsDataProvider);
            return moduleName;
        });
}());