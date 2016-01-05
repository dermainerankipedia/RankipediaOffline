(function() {
    'use strict';

    var serviceId = 'profileService';

    window.rankipediaApp.factory(serviceId, function () {
        var profileService = {};

        profileService.setProfileBriefActive = function () {
            profileService.resetActiveStates();
            profileService.profileBriefIsActive = true;
        }

        profileService.setAboutActive = function () {
            profileService.resetActiveStates();
            profileService.aboutIsActive = true;
        }

        profileService.setBusnessDetailActive = function () {
            profileService.resetActiveStates();
            profileService.busnessDetailIsActive = true;
        }

        profileService.setPortfolioActive = function () {
            profileService.resetActiveStates();
            profileService.portfolioIsActive = true;
        }

        profileService.setSpecialOffersActive = function () {
            profileService.resetActiveStates();
            profileService.specialOffersIsActive = true;
        }

        profileService.setReviewsctive = function () {
            profileService.resetActiveStates();
            profileService.reviewsIsActive = true;
        }

        profileService.setTestimonialsActive = function () {
            profileService.resetActiveStates();
            profileService.testimonialsIsActive = true;
        }

        profileService.setRankipediaShieldActive = function () {
            profileService.resetActiveStates();
            profileService.rankipediaShieldIsActive = true;
        }

        profileService.setUpgradeNowActive = function () {
            profileService.resetActiveStates();
            profileService.upgradeNowIsActive = true;
        }

        profileService.setProfileBriefActive = function () {
            profileService.resetActiveStates();
            profileService.contactIsActive = true;
        }

        profileService.resetActiveStates = function () {
            profileService.profileBriefIsActive = false;
            profileService.aboutIsActive = false;
            profileService.busnessDetailIsActive = false;
            profileService.portfolioIsActive = false;
            profileService.specialOffersIsActive = false;
            profileService.reviewsIsActive = false;
            profileService.testimonialsIsActive = false;
            profileService.rankipediaShieldIsActive = false;
            profileService.upgradeNowIsActive = false;
            profileService.contactIsActive = false;
        }


        return profileService;
    });
})();