(function() {
    "use strict";

    define(["./homeController"], function(homeController) {

        var moduleName = "myApp.home";

        angular
            .module(moduleName, [])
            .controller("homeController", homeController);

        return moduleName;
    });
}());