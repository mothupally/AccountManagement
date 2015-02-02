(function() {
    "use strict";

    define(["./aboutController"], function(aboutController) {

        var moduleName = "myApp.about";

        angular
            .module(moduleName, [])
            .controller("aboutController", aboutController);

        return moduleName;
    });
}());