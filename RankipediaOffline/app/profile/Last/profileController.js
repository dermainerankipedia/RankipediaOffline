(function() {
    'use strict';

    function profileController($scope, $location, profileConfig) {
        $scope.model = profileConfig.model;
        $scope.resetActiveStates = resetActiveStates;
        $scope.showProfileBrief = showProfileBrief;
        $scope.showAbout = showAbout;
        $scope.showBusnessDetail = showBusnessDetail;
        $scope.showPortfolio = showPortfolio;
        $scope.showSpecialOffers = showSpecialOffers;
        $scope.showReviews = showReviews;
        $scope.showTestimonials = showTestimonials;
        $scope.showRankipediaShield = showRankipediaShield;
        $scope.showUpgradeNow = showUpgradeNow;
        $scope.showContact = showContact;
        $scope.profileBriefIsActive = false;


        function showProfileBrief() {
            $location.path('/profilebrief');
            setProfileBriefActive();
        }

        function showAbout() {
            $location.path('/profileAbout');
            setAboutActive();
        }

        function showBusnessDetail() {
            $location.path('/profileBusinessDetail');
            setBusnessDetailActive();
        }

        function showPortfolio() {
            $location.path('/profilePortfolio');
            setPortfolioActive();
        }

        function showSpecialOffers() {
            $location.path('/profileSpecialOffers');
            setSpecialOffersActive();
        }

        function showReviews() {
            $location.path('/profileReviews');
            setReviewsctive();
        }

        function showTestimonials() {
            $location.path('/profileTestimonials');
            setTestimonialsActive();
        }

        function showRankipediaShield() {
            $location.path('/profileRankipediaShield');
            setRankipediaShieldActive();
        }

        function showUpgradeNow() {
            $location.path('/profileUpgradeNow');
            setUpgradeNowActive();
        }

        function showContact() {
            $location.path('/profileContact');
            setContactActive();
        }

        function setProfileBriefActive () {
            $scope.resetActiveStates();
            $scope.profileBriefIsActive = true;
        }

        function setAboutActive  () {
            $scope.resetActiveStates();
            $scope.aboutIsActive = true;
        }

        function setBusnessDetailActive () {
            $scope.resetActiveStates();
            $scope.busnessDetailIsActive = true;
        }

        function setPortfolioActive() {
            $scope.resetActiveStates();
            $scope.portfolioIsActive = true;
        }

        function setSpecialOffersActive () {
            $scope.resetActiveStates();
            $scope.specialOffersIsActive = true;
        }

        function setReviewsctive  () {
            $scope.resetActiveStates();
            $scope.reviewsIsActive = true;
        }

        function setTestimonialsActive () {
            $scope.resetActiveStates();
            $scope.testimonialsIsActive = true;
        }

        function setRankipediaShieldActive  () {
            $scope.resetActiveStates();
            $scope.rankipediaShieldIsActive = true;
        }

        function setUpgradeNowActive  () {
            $scope.resetActiveStates();
            $scope.upgradeNowIsActive = true;
        }

        function setContactActive () {
            $scope.resetActiveStates();
            $scope.contactIsActive = true;
        }

        function resetActiveStates () {
            $scope.profileBriefIsActive = false;
            $scope.aboutIsActive = false;
            $scope.busnessDetailIsActive = false;
            $scope.portfolioIsActive = false;
            $scope.specialOffersIsActive = false;
            $scope.reviewsIsActive = false;
            $scope.testimonialsIsActive = false;
            $scope.rankipediaShieldIsActive = false;
            $scope.upgradeNowIsActive = false;
            $scope.contactIsActive = false;
        }
    }

    var controllerId = 'profileController';
    window.rankipediaApp.controller(controllerId, ['$scope', '$location', 'profileConfig', profileController]);


})();