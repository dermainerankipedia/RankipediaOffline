(function() {
    'use strict';

    function profileBriefController($scope, $http, $window, $modal, $location, $filter, profileConfig) {
        
        $scope.model = profileConfig.model;
        $scope.editingModel = null;
        $scope.createAddressModel = null;
        $scope.createPhoneModel = null;
        

        $scope.onBeforeCreateAddress = onBeforeCreateAddress;
        $scope.onCreateAddress = onCreateAddress;
        $scope.onCancelCreateAddress = onCancelCreateAddress;

        $scope.onBeforeUpdateAddress = onBeforeUpdateAddress;
        $scope.onUpdateAddress = onUpdateAddress;
        $scope.onCancelUpdateAddress = onCancelUpdateAddress;
        $scope.onDeleteAddress = onDeleteAddress;

        $scope.onBeforeCreatePhone = onBeforeCreatePhone;
        $scope.onCreatePhone = onCreatePhone;
        $scope.onCancelCreatePhone = onCancelCreatePhone;

        $scope.onBeforeUpdatePhone = onBeforeUpdatePhone;
        $scope.onUpdatePhone = onUpdatePhone;
        $scope.onCancelUpdatePhone = onCancelUpdatePhone;
        $scope.onDeletePhone = onDeletePhone;
        

        function onBeforeCreateAddress($event) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope.createAddressModel = angular.copy($scope.model.defaultAddressViewModel);
            $scope.createAddressModel.isEditing = true;
        }

        function onCreateAddress(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.createAddressUrl, item)
                .success(function (data) {
                    data.isEditing = false;
                    addAddress(data);
                })
                .error(function (data) {

                }).finally(function () {
                    
                });
        }

        function onCancelCreateAddress(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();
            item.isEditing = false;
        }

        function onBeforeUpdateAddress(item) {
            item.isEditing = true;
            $scope.editingModel = angular.copy(item);
        }

        function onUpdateAddress(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.updateAddressUrl, item)
                .success(function (data) {
                    data.isEditing = false;
                    resetAddress(data);
                    
                })
                .error(function (data) {

                }).finally(function () {
                    $scope.editingModel = null;
                });
        }

        function onCancelUpdateAddress(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();
            if ($scope.editingModel) {
                $scope.editingModel.isEditing = false;
                resetAddress($scope.editingModel);
                $scope.editingModel = null;
            }

            item.isEditing = false;
        }

        function onDeleteAddress(item) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.deleteAddressUrl, { id: item.id })
                .success(function(data) {
                    deleteAddress(data);
                })
                .error(function(data) {

                }).finally(function() {
                   
                });
        }

        function deleteAddress(item) {
            
        }

        var deleteAddressModel = function(data) {
            
        };

        function resetAddress(model) {
            if ($scope.model.profileViewModel.profileBriefViewModel.addressViewModels && $scope.model.profileViewModel.profileBriefViewModel.addressViewModels.length > 1) {
                angular.forEach($scope.model.profileViewModel.profileBriefViewModel.addressViewModels, function (value, key) {
                    if (value.id == model.id) {
                        angular.copy(model, $scope.model.profileViewModel.profileBriefViewModel.addressViewModels[key]);
                        return;
                    }
                });
            }
        }

        function addAddress(model) {
            $scope.model.profileViewModel.profileBriefViewModel.addressViewModels.push(model);
        }


        function onBeforeCreatePhone($event) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope.createPhoneModel = angular.copy($scope.model.defaultPhoneViewModel);
            $scope.createPhoneModel.isEditing = true;
        }

        function onCreatePhone(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.createPhoneUrl, item)
                .success(function(data) {
                    data.isEditing = false;
                    item.isEditing = false;
                    addPhone(data);
                    item = null;
                })
                .error(function(data) {

                }).finally(function() {

                });
        }

        function onCancelCreatePhone(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();
            item.isEditing = false;
        }

        function onBeforeUpdatePhone(item) {
            item.isEditing = true;
            $scope.editingModel = angular.copy(item);
        }

        function onUpdatePhone(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.updatePhoneUrl, item)
                .success(function(data) {
                    resetPhone(data);
                   
                })
                .error(function(data) {

                }).finally(function() {
                    $scope.editingModel.isEditing = false;
                    item.isEditing = false;
                    $scope.editingModel = null;
                });
        }

        function onCancelUpdatePhone(item, $event) {
            $event.preventDefault();
            $event.stopPropagation();

            if ($scope.editingModel) {
                $scope.editingModel.isEditing = false;
                resetPhone($scope.editingModel);
                $scope.editingModel = null;
            }
           
            item.isEditing = false;
        }

        var deletePhone = function (data) { throw new Error("Not implemented"); };

        function onDeletePhone(item) {
            $event.preventDefault();
            $event.stopPropagation();

            $http.post(profileConfig.deletePhoneUrl, { id: item.id })
                .success(function (data) {
                    deletePhone(data);
                   
                })
                .error(function (data) {

                }).finally(function () {
                   
                });
        }

        function resetPhone(model) {
            if ($scope.model.profileViewModel.profileBriefViewModel.phoneViewModels && $scope.model.profileViewModel.profileBriefViewModel.phoneViewModels.length > 1) {
                angular.forEach($scope.model.profileViewModel.profileBriefViewModel.phoneViewModels, function (value, key) {
                    if (value.id == model.id) {
                        angular.copy(model, $scope.model.profileViewModel.profileBriefViewModel.phoneViewModels[key]);
                        return;
                    }
                });
            }
        }

        function addPhone(model) {
            $scope.model.profileViewModel.profileBriefViewModel.phoneViewModels.push(model);
        }


        function showStatus () {
            var selected = $filter('filter')($scope.model.jobStatuses, { value: $scope.model.profileViewModel.profileBriefViewModel.jobStatus });
            return ($scope.model.profileViewModel.profileBriefViewModel.jobStatus >-1 && selected.length > 0) ? selected[0].text : 'Not set';
        };
    }

    var controllerId = 'profileBriefController';
    window.rankipediaApp.controller(controllerId, ['$scope', '$http', '$window', '$modal', '$location', '$filter', 'profileConfig', profileBriefController]);

})();