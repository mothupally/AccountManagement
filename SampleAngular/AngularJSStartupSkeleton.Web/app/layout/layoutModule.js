(function () {
    "use strict";
    define(['./headerController'], function (headerController) {
        var modulename = 'myApp.layout';
        angular.module(modulename, []).controller('headerController', headerController);

        return modulename;
    });
}());