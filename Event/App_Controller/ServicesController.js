var app = angular.module("eventApp");




app.controller('serviceController', function ($scope, $http) {
    var vm = this;
    vm.services = ser;
    });

var ser = [
{
    "ImageURL": "../Images/aaa.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Birthday",
    "HashTag": "#corporate #cake #mehendi"

},
{
    "ImageURL": "../Images/Koala.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Birthday",
    "HashTag": "#wedding #birthday  #cake #sangeet"
},
{
    "ImageURL": "../Images/Lighthouse.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Birthday",
    "HashTag": "#wedding #birthday #corporate #cake #venue"
},
{
    "ImageURL": "../Images/Desert.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Birthday",
    "HashTag": "#wedding #birthday #venue"
},
{
    "ImageURL": "../Images/Chrysanthemum.jpg",
    "Name": "ServiceName",
    "Description": "Some Description about the service in detail. givce as much as information",
    "Category": "Wedding",
    "HashTag": "#wedding  #corporate #free"
},
{
    "ImageURL": "../Images/Hydrangeas.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Wedding",
    "HashTag": "#wedding   #cake"
},
{
    "ImageURL": "../Images/Tulips.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Wedding",
    "HashTag": "#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Jellyfish.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Wedding",
    "HashTag": "#wedding  #corporate #cake"
},
{
    "ImageURL": "../Images/aaa.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Wedding",
    "HashTag": "#wedding #birthday  #cake"
},
{
    "ImageURL": "../Images/Koala.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Corporate",
    "HashTag": " #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Lighthouse.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Corporate",
    "HashTag": "#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Desert.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Corporate",
    "HashTag": "#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Chrysanthemum.jpg",
    "Name": "Service1",
    "Description": "SomeDescription",
    "Category": "Corporate",
    "HashTag": "#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Hydrangeas.jpg",
    "Name": "ServiceName",
    "Description": "Description1",
    "Category": "Corporate",
    "HashTag": "#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Tulips.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Birthday",
    "HashTag":"#wedding #birthday #corporate #cake"
},
{
    "ImageURL": "../Images/Jellyfish.jpg",
    "Name": "ServiceName",
    "Description": "SomeDescription",
    "Category": "Wedding",
    "HashTag":"#wedding #birthday #corporate #cake"
}

];


