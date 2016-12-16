/// <reference path="../Scripts/angular.js" />
/// <reference path="../Scripts/angular-ui-router.min.js" />

angular.module("eventApp").controller('listServiceController', function ($http) {
    var vm = this;
    vm.Services = [];
    vm.Services = $http.get("http://localhost:5623/api/values");

    //$http({
    //    method: 'GET',
    //    url: 'http://localhost:5623/api/values'
    //})
    //.then(function (response) {
    //    vm.Services = response.data;
    //});
});



//angular.module("eventApp").controller('addServiceController', function ($http) {
//    var vm = this;

//    vm.offeredServices = {
//        'Name': 'Music',
//        'ImageURL': '../Images/Desert.jpg',
//        'Description': 'Best music in the town',
//        'Category': 'Wedding',
//        'HashTag': '#wedding #birthday'
//    };
//    vm.addService = function () {
//        $http({
//            method: 'POST',
//            url: 'http://localhost:5623/api/values',
//            data: JSON.stringify(vm.offeredServices),
//            Contect-Type: application/JSON,
//            dataType: "json"
//        })
//    .then(function (response) {
//        alert("Service added successfully...");
//    });
//    };

//});


//angular.module("eventApp").controller('deleteServiceController', function ($http) {
//    var vm = this;
//    vm.deleteService = function (ID) {
//        $http({
//            method: 'DELETE',
//            url: 'http://localhost:5623/api/values' + ID,
//            data: ID
//        })
//    .then(function (response) {
//        alert("Service deleted successfully...");
//    });
//    };

//});




