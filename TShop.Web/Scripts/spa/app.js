
/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

//myController.$inject = ['$scope'];

//declare
function schoolController ($rootScope,$scope)
{
    $rootScope.message = "This is my message School";
}

function studentController($scope) {
    //$scope.message = "This is my message from Teacher";
}
function teacherController ($scope)
{
    
}