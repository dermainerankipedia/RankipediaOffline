(function() {
    'use strict';

    window.rankipediaApp.config([
        '$routeProvider', '$locationProvider',
        function($routeProvider, $locationProvider) {
            $routeProvider
                .when('/profilebrief', {
                    template: '<profile-brief />',
                    controller: 'profileBriefController',
                    controllerAs: 'profilebrief'
                }).
                //.when('/profileAbout', {
                //    template: '<profile-brief />',
                //    controller: 'profileAboutController',
                //    controllerAs: 'profileAbout'
                //}).
                otherwise({
                    //redirectTo: '/profilebrief'
                });

            //$locationProvider.html5Mode(true);
        }
    ]);


})();