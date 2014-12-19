'use strict';

angular.module('myApp.student-page', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/student-page', {
            templateUrl: 'student-page/student-page.html',
            controller: 'StudentPageCtrl'
        });
    }])

    .controller('StudentPageCtrl', ['$scope', function ($scope) {
        $scope.student = {
            name: 'Pesho',
            photo: 'http://www.nakov.com/wp-content/uploads/2014/05/SoftUni-Logo.png',
            grade: 5,
            school: 'High School of Mathematics',
            teacher: 'Gichka Pesheva'
        };

        $scope.photoStyle = {
            width: '100px',
            paddingLeft: '20px'
        };
    }]);
