(function () {
    'use strict';

    //window.onerror = function (msg) {
    //    if (window.alerts) {
    //        window.alerts.error("There was a problem with your last action.  Please reload the page, then try again.");
    //    } else {
    //        alert("Something serious went wrong.  Please close out of Fail Tracker, then try again.");
    //    }
    //};


    window.rankipediaApp = angular.module("rankipediaApp", ['ui.bootstrap', 'ngRoute', 'xeditable', 'checklist-model']);

  
    window.rankipediaApp.run(function (editableOptions) {
        editableOptions.theme = 'bs3'; // bootstrap3 theme. Can be also 'bs2', 'default'
    });

    //We already have a limitTo filter built-in to angular,
    //let's make a startFrom filter
    window.rankipediaApp.filter('startFrom', function () {
        return function (input, start) {
            start = +start; //parse to int
            return input.slice(start);
        }
    });


})();
