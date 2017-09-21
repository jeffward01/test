'use strict';
app.controller('addCustomerController', '$rootScope', '$state', 'githubService', 'projectService', 'alertService', function($scope,
    $rootScope,
    $state,
    githubService,
    projectService,
    alertService, customerService) {
    $scope.portfolioCats = 0;
    $scope.blockchainProjects = [];
    $scope.generalProjects = [];


    $scope.customer = {};
    

    $scope.addCustomer = function() {

        customerService.addCustomer(customer).then(function(result) {
            alertService.successTimeout("Customer successfully created!");
                $state.go('app.home', {});
            },
            function(err) {
                alertService.error("Error creating Customer");
            });
    }
    









});