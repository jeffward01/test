angular.module('app')
    .factory('stateManager', ['$document', '$state', function ($document, $state) {
        var stateMangerFactory = {}

        var _goToLandingPage = function () {
            $state.go('app.landingPage', {});
        }

        var _goToContactUs = function () {
            $state.go('app.contactUs', {});
        }

        var _goToBlog = function () {
            $state.go('app.blog', {});
        }

        var _goToForum = function () {
            $state.go('app.forum', {});
        }

        var _goToConfirmRegistration = function () {
            $state.go('app.confirmRegistration', {});
        }

        var _goToLogin = function () {
            $state.go('app.login', {});
        }

        var _goToMyProfile = function (nootBaseUserId) {
            $state.go('app.profile', { preLaunchUserId: nootBaseUserId });
        }

        var _goToHome = function () {
            $state.go('app.home', {});
        }

        var _goToCreateAccount = function () {
            $state.go('app.createAccount', {});
        }

        var _goToSearch = function () {
            $state.go('app.search', {});
        }

        var _goToNootropicDetail = function (nootId) {
            $state.go('app.nootropic.detail', { nootropicId: nootId });
        }

        var _goToAddNootropic = function (userId) {
            $state.go('app.nootropic.addNootropic', { userId: userId });
        }

        var _goToAddReview = function (nootId, userId) {
            $state.go('app.nootropic.addReview', { nootropicId: nootId, userId: userId });
        }

        var _goToSettings = function (nootId) {
            $state.go('app.profile.profileSettings', { nootBaseId: nootId });

        }

        var _goToAddReviewDetail = function (nootId, nootReviewId, userId) {
            $state.go('app.nootropic.reivewDetail', { nootropicId: nootId, nootropicReviewId: nootReviewId, userId: userId });
        }

        var _goToStackDetail = function (sId) {
            $state.go('app.stack.detail', { stackId: sId });
        }

        var _goToAddStack = function (uId) {
            $state.go('app.stack.addStack', { userId: uId });
        }

        var _goToAddStackReview = function (sId, uId) {
            $state.go('app.stack.addReview', { stackId: sId, userId: uId });
        }

        var _goToStackReviewDetail = function (sId, stackReviewId, uId) {
            $state.go('app.stack.reviewDetail', { stackId: sId, stackReviewId: stackReviewId, userId: uId });
        }

        var _goToJournalDetail = function (uId) {
            $state.go('app.journal.detail', { userId: uId });
        }

        var _goToAddJournal = function (uId) {
            $state.go('app.journal.addJournal', { userId: uId });
        }

        var _goToJournalEntry = function (jId, jeId) {
            $state.go('app.journal.viewJournalEntry', { journalId: jId, journalEntryId: jeId });
        }

        var _goToVendorDetail = function (vId) {
            $state.go('app.vendor.detail', { vendorId: vId });
        }
        var _goToAddVendor = function (uId) {
            $state.go('app.vendor.addVendor', { userId: uId });
        }
        var _goToAddVendorReview = function (uId) {
            $state.go('app.vendor.addVendorReview', { userId: uId });
        }
        var _goToAddVendorProductReview = function (uId, vId) {
            $state.go('app.vendor.addProductReview', { userId: uId, vendorId: vId });
        }

        var _forgotPassword = function () {
            $state.go('app.forgotPassword', {});
        }

        var _goToConfirmEmail = function (uId, confirmId) {
            $state.go('app.profile.confirmEmail', { nootBaseId: uId, confirmationId: confirmId });
        }

        var _goToUpdateEmail = function (uId) {
            $state.go('app.profile.updateEmail', { nootBaseId: uId });
        }

        var _goToVerifyEmail = function (uId) {
            $state.go('app.profile.verifyEmail', { nootBaseId: uId });
        }

        var _goToUserProfile = function (uId) {
            $state.go('app.profile.userProfile', { nootBaseId: uId });
        }

        stateMangerFactory.goToConfirmRegistration = _goToConfirmRegistration;




        return stateMangerFactory;
    }]);
