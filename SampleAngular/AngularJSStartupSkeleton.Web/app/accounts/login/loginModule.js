(function() {
    "use strict";

    define(["./loginController"], function(loginController) {

        var moduleName = "myApp.login";

        angular
            .module(moduleName, [])
            .controller("loginController", loginController);

        return moduleName;
    });
}());