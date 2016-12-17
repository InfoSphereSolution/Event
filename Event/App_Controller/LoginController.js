/// <reference path="../Scripts/angular.js" />
angular.module('eventApp')
.controller('loginController', function ($location) {
    var vm = this;
    vm.submit = function () {
        var uname = vm.username;
        var pswd = vm.password;
        if (vm.username == "admin" && vm.password == "admin")
        {
            $location.path('/dashboard');
        }
    };
});