(function () {
    'use strict';

    window.rankipediaApp.directive("phoneContactList", phoneContactList);

    function phoneContactList() {
        return {
            scope: {
                newItem: '=',
                items: '=',
                editable: '=',
                types: '=',
                isopen: '=',
                'beforecreate': '&onBeforeCreate',
                'create': '&onCreate',
                'cancelcreate': '&onCancelCreate',
                'beforeupdate': '&onBeforeUpdate',
                'update': '&onUpdate',
                'cancelupdate': '&onCancelUpdate',
                'delete': '&onDelete',
                'toggleDropdown': '&onToggleDropdown'
            },
            restrict: 'E',
            templateUrl: '/directives/template/phonecontactList.tmpl.cshtml',
            link: function (scope, element, attrs) {
               
            }
        }
    };

})();