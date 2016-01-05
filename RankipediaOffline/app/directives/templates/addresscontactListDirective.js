(function () {
    'use strict';

    window.rankipediaApp.directive("addressContactList", addressContactList)
        .controller('Controller', ['$scope', function ($scope) {

            $scope.currentPage = 0;
            $scope.pageSize = 1;
            $scope.numberOfPages = function () {
                return Math.ceil($scope.data.length / $scope.pageSize);
            }
            
    }]);

    function addressContactList() {
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
            templateUrl: '/directives/template/addresscontactList.tmpl.cshtml',
            controller: controller,
            controllerAs: 'vm'
        }
    };


    controller.$inject = ['$scope'];

    function controller($scope) {

        $scope.currentPage = 0;
        $scope.pageSize = 1;
        $scope.addingNew = false;

        $scope.numberOfPages = function () {
            return Math.ceil($scope.items.length / $scope.pageSize);
        }

        $scope.getPageIndex = function () {
            var index = ($scope.pageSize * $scope.currentPage);
            return index;
        }

        $scope.nextPageClicked = function ($event) {
            $scope.cancelupdate({ item: $scope.getCurrentItem(), $event: $event });
            $scope.currentPage = $scope.currentPage + 1;
        }

        $scope.previousPageClicked = function ($event) {
            $scope.cancelupdate({ item: $scope.getCurrentItem(), $event: $event });
            $scope.currentPage = $scope.currentPage - 1;
        }

        $scope.previousIsDisabled = function () {
            return ($scope.currentPage == 0);
        }

        $scope.nextIsDisabled = function () {
            return ($scope.currentPage >= ($scope.items.length / $scope.pageSize - 1));
        }

        $scope.getCurrentItem = function () {
            var item = null;
            if ($scope.items && $scope.items.length > 0 && $scope.items.length > $scope.currentPage) {
                item = $scope.items[$scope.currentPage];
            }

            return item;
        }
    }

})();