'use strict';
app.controller('homeController', ['$scope', '$rootScope', '$state', 'githubService', 'projectService', 'alertService', function ($scope, $rootScope, $state, githubService, projectService, alertService, customerService) {
    $scope.portfolioCats = 0;
    $scope.blockchainProjects = [];
    $scope.generalProjects = [];

 

    function getAllCustomers() {
        customerService.getAllCustomers().then(function (result) {
            $scope.customers = result.data;
        });

    }
}]);