'use strict';

var app = app || {};

app.controller = (function () {
    function BaseController(data) {
        this._data = data;
    }

    BaseController.prototype.loadWelcome = function (selector) {
        $('#menu').hide();
        $(selector).load('templates/welcome.mustache');
    };

    BaseController.prototype.loadHome = function (selector) {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            var userId = currentUser.objectId;
            $(selector).data('id', userId);
            this._data.users.getById(userId)
                .then(
                function (data) {
                    $.get('templates/home.mustache', function (template) {
                        var output = Mustache.render(template, data);
                        $(selector).html(output);
                    });
                }
            );
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.loadLogin = function (selector) {
        $('#menu').hide();
        $(selector).load('templates/login.mustache');
    };

    BaseController.prototype.loadRegister = function (selector) {
        $('#menu').hide();
        $(selector).load('templates/register.mustache');
    };

    BaseController.prototype.loadPhonebook = function (selector) {
        var currentUser = userSession.getCurrentUser();
        if(currentUser) {
            this._data.phones.getAll()
                .then(
                function (data) {
                    $.get('templates/phonebook.mustache', function (template) {
                        var output = Mustache.render(template, data);
                        $(selector).html(output);
                    });
                },
                function (error) {
                    Noty.error(error);
                });
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.loadAddPhone = function (selector) {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            $(selector).load('templates/add-phone.mustache');
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.loadEditPhone = function (selector, phoneId) {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            var _this = this;

            $(selector).on('click', '.edit', function () {
                _this._data.phones.getById(phoneId)
                    .then(
                    function (data) {
                        $.get('templates/edit-phone.mustache', function (template) {
                            var output = Mustache.render(template, data);
                            $(selector).html(output);
                        });
                    }
                );
            });
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.loadDeletePhone = function (selector, phoneId) {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            var _this = this;

            $(selector).on('click', '.delete', function () {
                _this._data.phones.getById(phoneId)
                    .then(
                    function (data) {
                        console.log(data);
                        $.get('templates/delete-phone.mustache', function (template) {
                            var output = Mustache.render(template, data);
                            $(selector).html(output);
                        });
                    }
                );
            });
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.loadEditProfile = function (selector) {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            $.get('templates/edit-profile.mustache', function (template) {
                var output = Mustache.render(template, currentUser);
                $(selector).html(output);
            });
        } else {
            $(selector).load('templates/welcome.mustache');
        }
    };

    BaseController.prototype.logout = function () {
        userSession.logout();
        window.history.replaceState('', '', '#/');
    };

    var attachLoginHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#login-btn', function (ev) {
            ev.preventDefault();
            var username = $('#username').val();
            var password = $('#password').val();

            _this._data.users.login(username, password)
                .then(
                function (data) {
                    $(selector).data('id', data.objectId);
                    Noty.success('Login successful');
                    userSession.login(data);
                    window.history.replaceState('home', 'home', '#/home');
                },
                function (error) {
                    Noty.error('Invalid login');
                });
        });
    };

    var attachRegisterHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#register-btn', function (ev) {
            ev.preventDefault();
            var username = $('#username').val();
            var password = $('#password').val();
            var fullName = $('#fullName').val();

            _this._data.users.register(username, password, fullName)
                .then(
                function (data) {
                    $(selector).data('id', data.objectId);
                    userSession.login(data);
                    Noty.success('Successfully register');
                    window.history.replaceState('home', 'home', '#/home');
                },
                function (error) {
                    Noty.error('Invalid registration');
                });
        });
    };

    var attachCreatePhoneHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#add-phone-btn', function (ev) {
            ev.preventDefault();
            var name = $('#personName').val();
            var number = $('#phoneNumber').val();
            var currentUser = userSession.getCurrentUser();

            var phone = {
                name: name,
                number: number,
                ACL: {}
            };

            phone.ACL[currentUser.objectId] = {
                "write": true,
                "read": true
            };

            _this._data.phones.add(phone)
                .then(function (data) {
                    Noty.success('Phone added successfully');
                    window.history.replaceState('phonebook', 'phonebook', '#/phonebook');
                },
                function (error) {
                    Noty.error(error);
                });
        });
    };

    var attachDeletePhoneHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#delete-phone-btn', function (ev) {
            ev.preventDefault();
            var phoneId = $(this).data('id');
            _this._data.phones.delete(phoneId)
                .then(
                function () {
                    Noty.success('Phone deleted successfully');
                    window.history.replaceState('phonebook', 'phonebook', '#/phonebook');
                },
                function (error) {
                    Noty.error(error);
                });
        });
    };

    var attachEditPhoneHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#edit-phone-btn', function (ev) {
            ev.preventDefault();
            var name = $('#personName').val();
            var number = $('#phoneNumber').val();

            var phone = {
                name: name,
                number: number
            };
            var phoneId = $(this).data('id');

            _this._data.phones.edit(phone, phoneId)
                .then(
                function () {
                    Noty.success('Phone edited successfully');
                    window.history.replaceState('phonebook', 'phonebook', '#/phonebook');
                },
                function (error) {
                    Noty.error(error);
                });
        });
    };

    var attachEditProfileHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#edit-profile-btn', function (ev) {
            ev.preventDefault();
            var username = $('#username').val();
            var password = $('#password').val();
            var fullName = $('#fullName').val();
            var currentUser = userSession.getCurrentUser();
            var userId = currentUser.objectId;

            _this._data.users.edit(username, password, fullName, userId)
                .then(
                function () {
                    Noty.success('Profile edited successfully');
                    window.history.replaceState('home', 'home', '#/home');
                },
                function (error) {
                    Noty.error(error);
                });
        });
    };

    BaseController.prototype.attachEventHandlers = function () {
        var selector = '#wrapper';
        attachLoginHandler.call(this, selector);
        attachRegisterHandler.call(this, selector);
        attachCreatePhoneHandler.call(this, selector);
        attachDeletePhoneHandler.call(this, selector);
        attachEditPhoneHandler.call(this, selector);
        attachEditProfileHandler.call(this, selector);
    };

    return {
        get: function (data) {
            return new BaseController(data);
        }
    };
}());
