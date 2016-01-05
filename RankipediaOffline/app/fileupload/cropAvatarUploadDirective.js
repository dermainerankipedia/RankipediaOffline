(function() {
    'use strict';

    window.rankipediaApp.directive("cropAvatarUpload", ['cropAvatarUploadService', cropAvatarUpload]);

    function cropAvatarUpload(cropAvatarUploadService) {


        return {
            restrict: 'E',
            templateUrl: '/fileupload/template/cropAvatarUploadModal.tmpl.cshtml',
            link: function(scope, elm, attrs) {

                function init() {
                    var $containerName = attrs.avatarContainerName;
                    cropAvatarUploadService.init($containerName);
                }


                init();
            }
    };
    }

    

})();