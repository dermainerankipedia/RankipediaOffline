(function () {
    'use strict';

    window.rankipediaApp.directive("profileBrief", profileBrief);

    function profileBrief() {
        return {
            restrict: 'E',
            templateUrl: '/profile/template/profilebrief.tmpl.cshtml',
        }
    };

})();