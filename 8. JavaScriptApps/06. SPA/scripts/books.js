'use strict';

var app = app || {};

(function () {
    var baseUrl = 'https://api.parse.com/1/';
    var ajaxRequester = app.ajaxRequester.get();
    var data = app.data.get(baseUrl, ajaxRequester);
    var controller = app.controller.get(data);
    controller.attachEventHandlers();

    app.router = Sammy(function () {
        var selector = '#wrapper';

        this.get('#/books', function () {
            controller.loadBooks(selector);
        });
    });

    app.router.run('#/books');
}());