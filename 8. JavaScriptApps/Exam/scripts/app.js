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

        this.get('#/', function () {
            controller.loadWelcome(selector);
        });

        this.get('#/home', function () {
            controller.loadHome(selector);
        });

        this.get('#/login', function () {
            controller.loadLogin(selector);
        });

        this.get('#/register', function () {
            controller.loadRegister(selector);
        });

        this.get('#/phonebook', function () {
            controller.loadPhonebook(selector);
        });

        this.get('#/phone/add', function () {
            controller.loadAddPhone(selector);
        });

        this.get('#/phone/edit/:id', function () {
            controller.loadEditPhone(selector, this.params['id']);
        });

        this.get('#/phone/delete/:id', function () {
            controller.loadDeletePhone(selector, this.params['id']);
        });

        this.get('#/profile/edit', function () {
            controller.loadEditProfile(selector);
        });

        this.get('#/logout', function () {
            controller.logout();
        });
    });

    app.router.run('#/');
}());
