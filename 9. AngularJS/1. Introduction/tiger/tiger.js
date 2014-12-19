'use strict';

angular.module('myApp.tiger', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/tiger', {
            templateUrl: 'tiger/tiger.html',
            controller: 'TigerCtrl'
        });
    }])

    .controller('TigerCtrl', ['$scope', function ($scope) {
        $scope.tiger = {
            'Name': 'Pesho',
            'Born': 'Asia',
            'BirthDate': 2006,
            'Live': 'Sofia Zoo',
            'ImageUrl': 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg'
        };

        $scope.containerStyle = {
            backgroundColor: '#ccc',
            display: 'inline-block',
            padding: '20px',
            width: '300px'
        };

        $scope.subContainerStyle = {
            display: 'inline-block',
            width: '45%',
            verticalAlign: 'top'
        };

        $scope.labelStyle = {
            fontWeight: 'bold'
        };

        $scope.headingStyle = $.extend($scope.labelStyle, {
            textAlign: 'center'
        });

        $scope.imageStyle = {
            width: '100%'
        };
    }]);
