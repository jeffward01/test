'use strict';
app.controller('editCustomerController', '$rootScope', '$state','$stateParams', 'githubService', 'projectService', 'alertService', function ($scope,
    $rootScope,
    $state,
    githubService,
    projectService,
    alertService, customerService) {
    $scope.portfolioCats = 0;
    $scope.blockchainProjects = [];
    $scope.generalProjects = [];


    $scope.customer = getCustomer($stateParams.customerId);




    function getCustomer(customerId) {
        var customer = {};
        customerService.getCustomerById(customerId).then(function(result) {
            customer = result.data;
        });
        return customer;

    }


    $scope.editCustomer = function () {

        customerService.editCustomer(customer).then(function (result) {
                alertService.successTimeout("Customer successfully created!");
                $state.go('app.home', {});
            },
            function (err) {
                alertService.error("Error creating Customer");
            });
    }










});