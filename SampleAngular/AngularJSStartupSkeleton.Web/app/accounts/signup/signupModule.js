(function() {
    "use strict";

    define(["./signupController"], function(signupController) {

        var moduleName = "myApp.signup";

        angular
            .module(moduleName, [])
            .controller("signupController", signupController);

        return moduleName;
    });
}());