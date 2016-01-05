(function () {
    'use strict';

    var serviceId = 'cropAvatarUploadService';

    window.rankipediaApp.factory(serviceId, function () {
        var cropAvatarUploadService = {};
        cropAvatarUploadService.cropAvatars = [];

        cropAvatarUploadService.init = function (containerName) {

            try {
                var cropAvatar = new $.fn.cropAvatar(containerName);
                this.add(containerName, cropAvatar);
            } catch (e) {
                alert(e);
            }
           
        }
        cropAvatarUploadService.add = function (containerName, cropAvatar) {
            cropAvatarUploadService.cropAvatars.push({ name: containerName, cropAvatar: cropAvatar });
        }
        cropAvatarUploadService.remove = function (containerName) {
            $.each(cropAvatarUploadService.cropAvatars, function (index, element) {
                if (this.name == containerName) {
                    cropAvatarUploadService.cropAvatars.splice(index, 1);
                }
            });
        }

        return cropAvatarUploadService;
    });
})();