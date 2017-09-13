/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.service('Validator', Validator);

schoolController.$inject=['$scope', 'Validator'];

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber(2);
       
    }
    $scope.num = 1;
}

function Validator($window) {
    return {
        checkNumber: checkNumber // Ten phuong thuc dung ngoai : ten phuong thuc noi bo
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'this is even';
        }
        else {
            return 'this is odd';
        }
    }
}