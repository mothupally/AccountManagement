(function() {
    "use strict";

    define(["./contactController"], function(contactController) {

        var moduleName = "myApp.contact";

        angular
            .module(moduleName, [])
            .controller("contactController", contactController);

        return moduleName;
    });
}());