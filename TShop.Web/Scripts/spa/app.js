/// <reference path="tShopDirective.html" />
/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);

myApp.directive("tShopDirective", tShopDirective);

myApp.service('validatorService', Validator);

schoolController.$inject = ['$scope', 'validatorService'];

function schoolController($scope, validatorService) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber(2);
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

function tShopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/tShopDirective.html"
    }
}