(function () {
    "use strict";

    define(["./contact/contactController", "./signup/signupController",
        "./login/loginController", "./about/aboutController",
        "./home/homeController", "./mysettings/usersettingsController", "./accountsDataProvider"],
        function (contactController, signupController,
            loginController, aboutController, homeController,
            usersettingsController, accountsDataProvider) {

            var moduleName = "myApp.accountsModule";
            angular
                .module(moduleName, [])
                .controller("contactController", contactController)
                .controller("signupController", signupController)
                .controller("loginController", loginController)
                .controller("aboutController", aboutController)
                .controller("homeController", homeController)
                .controller("usersettingsController", usersettingsController)
                .factory("accountsDataProvider", accountsDataProvider);
            return moduleName;
        });
}());