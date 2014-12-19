'use strict';

angular.module('myApp.bind-image', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/bind-image', {
            templateUrl: 'bind-image/bind-image.html',
            controller: 'BindImageCtrl'
        });
    }])

    .controller('BindImageCtrl', ['$scope', function ($scope) {
        $scope.imageUrl = 'http://joomlaworks.net/images/demos/galleries/abstract/7.jpg';

        $scope.imageStyle = {
            padding: '20px'
        };
    }]);
