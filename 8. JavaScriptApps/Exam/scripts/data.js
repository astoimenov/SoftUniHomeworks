'use strict';

var app = app || {};

app.data = (function () {
    function Data(baseUrl, ajaxRequester) {
        this.users = new Users(baseUrl, ajaxRequester);
        this.phones = new Phones(baseUrl, ajaxRequester);
    }

    var credentials = (function () {
        function getSessionToken() {
            sessionStorage.getItem('sessionToken');
        }

        function setSessionToken(sessionToken) {
            sessionStorage.setItem('sessionToken', sessionToken);
        }

        function getUsername() {
            sessionStorage.getItem('username');
        }

        function setUsername(username) {
            sessionStorage.setItem('username', username);
        }

        var headers = {
            'X-Parse-Application-Id': 'E1ZmmIAZCAY8o1z7523lUbwgvdTY3RFNTfuhbafi',
            'X-Parse-REST-API-Key': 'Mh9LKEdFxjtZGic11jZL2HSAXewF9sc10eRvLpap',
            'X-Parse-Session-Token': getSessionToken()
        };

        function getHeaders() {
            return headers;
        }

        return {
            getSessionToken: getSessionToken,
            setSessionToken: setSessionToken,
            getUsername: getUsername,
            setUsername: setUsername,
            getHeaders: getHeaders
        };
    }());

    var Users = (function () {
        function Users(baseUrl, ajaxRequester) {
            this._serviceUrl = baseUrl;
            this._ajaxRequester = ajaxRequester;
            this._headers = credentials.getHeaders();
        }

        Users.prototype.login = function (username, password) {
            var url = this._serviceUrl + 'login?username=' + username + '&password=' + password;

            return this._ajaxRequester.get(url, this._headers)
                .then(function (data) {
                    credentials.setSessionToken(data.sessionToken);
                    credentials.setUsername(data.username);

                    return data;
                });
        };

        Users.prototype.register = function (username, password, fullName) {
            var url = this._serviceUrl + 'users';
            var user = {
                username: username,
                password: password,
                fullName: fullName
            };

            return this._ajaxRequester.post(url, user, this._headers)
                .then(function (data) {
                    credentials.setSessionToken(data.sessionToken);

                    return data;
                });
        };

        Users.prototype.getById = function (objectId) {
            var url = this._serviceUrl + 'users/' + objectId;
            return this._ajaxRequester.get(url, this._headers);
        };

        Users.prototype.edit = function (username, password, fullName, userId) {
            var url = this._serviceUrl + 'users/' + userId;
            var user = {
                username: username,
                password: password,
                fullName: fullName
            };

            this._headers['X-Parse-Session-Token'] = sessionStorage.getItem('sessionToken');

            return this._ajaxRequester.put(url, user, this._headers);
        };

        return Users;
    }());

    var Phones = (function () {
        function Phones(baseUrl, ajaxRequester) {
            this._serviceUrl = baseUrl + 'classes/Phone';
            this._ajaxRequester = ajaxRequester;
            this._headers = credentials.getHeaders();
        }

        Phones.prototype.getAll = function () {
            this._headers['X-Parse-Session-Token'] = sessionStorage.getItem('sessionToken');
            return this._ajaxRequester.get(this._serviceUrl, this._headers);
        };

        Phones.prototype.getById = function (objectId) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.get(url, this._headers);
        };

        Phones.prototype.add = function (phone) {
            return this._ajaxRequester.post(this._serviceUrl, phone, this._headers);
        };

        Phones.prototype.edit = function (phone, objectId) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.put(url, phone, this._headers);
        };

        Phones.prototype.delete = function (objectId) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.delete(url, this._headers);
        };

        return Phones;
    }());

    return {
        get: function (baseUrl, ajaxRequester) {
            return new Data(baseUrl, ajaxRequester);
        }
    };
}());
