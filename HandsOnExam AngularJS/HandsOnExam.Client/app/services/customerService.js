angular.module('app')
    .factory('customerService', [
        '$http', '$q',
        function ($http, $q, serviceUrl) {


            var customerServiceFactory = {};


            var _getAllCustomers = function () {
                var url = serviceUrl + "/api/Customer/GetAllCustomers";
                var deferred = $q.defer();
                $http.get(url).then(function (result) {
                        deferred.resolve(result);
                    },
                    function (err) {
                        deferred.reject(err);
                    });
                return deferred.promise;
            };

            var _getCustomerById = function (customerId) {
                var url = serviceUrl + "/api/Customer/GetCustomerById/" + customerId;
                var deferred = $q.defer();
                $http.get(url).then(function (result) {
                        deferred.resolve(result);
                    },
                    function (err) {
                        deferred.reject(err);
                    });
                return deferred.promise;
            };

            var _addCustomer = function (customer) {
                var url = serviceUrl + "/api/Customer/AddCustomer";
                var deferred = $q.defer();
                $http.post(url, customer)
                    .success(function (response) {
                        deferred.resolve(response);
                    }).error(function (response) {
                        deferred.reject(response);
                    });
                return deferred.promise;
            };


            var _editCustomer = function (customer) {
                var url = serviceUrl + "/api/Customer/EditCustomer";
                var deferred = $q.defer();
                $http.post(url, customer)
                    .success(function (response) {
                        deferred.resolve(response);
                    }).error(function (response) {
                        deferred.reject(response);
                    });
                return deferred.promise;
            };


            var _deleteCustomer = function (customerId) {
                var url = serviceUrl + "/api/Customer/DeleteCustomer/" + customerId;
                var deferred = $q.defer();
                $http.post(url)
                    .success(function (response) {
                        deferred.resolve(response);
                    }).error(function (response) {
                        deferred.reject(response);
                    });
                return deferred.promise;
            };


            customerServiceFactory.getAllCustomers = _getAllCustomers;
            customerServiceFactory.getCustomerById = _getCustomerById;
            customerServiceFactory.addCustomer = _addCustomer;
            customerServiceFactory.editCustoemr = _editCustomer;
            customerServiceFactory.deleteCustomer = _deleteCustomer


            return customerServiceFactory;


        }
    ]);
