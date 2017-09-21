'use strict';
app.controller('customersController', '$rootScope', '$state', '$stateParams', 'githubService', 'projectService', 'alertService', function ($scope,
    $rootScope,
    $state,
    githubService,
    projectService,
    alertService, customerService) {
    $scope.portfolioCats = 0;
    $scope.blockchainProjects = [];
    $scope.generalProjects = [];


    $scope.customers = [];
    $scope.customers = getAllCustomers();









    function getAllCustomers() {
        customerService.getAllCustomers().then(function (result) {
            $scope.customers = result.data;
        });

    }







});