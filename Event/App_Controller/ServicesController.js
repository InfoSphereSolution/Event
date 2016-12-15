/// <reference path="../Scripts/angular.js" />
/// <reference path="../Scripts/angular-ui-router.min.js" />

angular.module("eventApp").controller('listServiceController', function ($http) {
    var vm = this;
    $http({
        method: 'GET',
        url: 'App_WebService/Services.asmx/fetchServices'
    })
    .then(function (response) {
        vm.Services = response.data;
    });
});



angular.module("eventApp").controller('addServiceController', function ($http) {
    var vm = this;

    vm.offeredServices = {
        'Name': 'Music',
        'ImageURL': '../Images/Desert.jpg',
        'Description': 'Best music in the town',
        'Category': 'Wedding',
        'HashTag': '#wedding #birthday'
    };
    vm.addService = function () {
        $http({
            method: 'POST',
            url: 'App_WebService/Services.asmx/addServices',
            data: JSON.stringify(vm.offeredServices),
            dataType: "json"
        })
    .then(function (response) {
        alert("Service added successfully...");
    });
    };

});


angular.module("eventApp").controller('deleteServiceController', function ($http) {
    var vm = this;
    vm.deleteService = function (ID) {
        $http({
            method: 'POST',
            url: 'App_WebService/Services.asmx/deleteServices',
            data: ID
        })
    .then(function (response) {
        alert("Service deleted successfully...");
    });
    };

});




