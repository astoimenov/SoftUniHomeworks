'use strict';

angular.module('myApp', [
    'ngRoute',
    'myApp.student-page',
    'myApp.bind-image',
    'myApp.tiger'
]).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider.otherwise({
                redirectTo: '/student-page'
            });
    }]);
