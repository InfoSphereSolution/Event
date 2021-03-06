﻿/// <reference path="../Scripts/angular.js" />
/// <reference path="../Scripts/angular-ui-router.min.js" />


angular.module("eventApp", ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/Home');
        $stateProvider
             .state('home', {
                 url: "/Home",
                 templateUrl: "Pages/HomeContent.html"
             })

            .state('services', {
                url: '/Services',
                templateUrl: 'Pages/Services.html'
            })

            .state('photos', {
                url: '/Photos',
                templateUrl: 'Pages/Photos.html',
            })

            .state('videos', {
                url: '/Videos',
                templateUrl: 'Pages/Videos.html'
            })

            .state('aboutus', {
                url: '/AboutUs',
                templateUrl: 'Pages/AboutUs.html'
            })

            .state('contactus', {
                url: '/ContactUs',
                templateUrl: 'Pages/ContactUs.html'
            })

             .state('login', {
                url: "/Login",
                templateUrl: "Pages/Login.html"
        })

    });


