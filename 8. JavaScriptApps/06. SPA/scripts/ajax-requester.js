'use strict';

var app = app || {};

app.ajaxRequester = (function () {
    function AjaxRequester() {
        this.get = makeGetRequest;
        this.post = makePostRequest;
        this.put = makePutRequest;
        this.delete = makeDeleteRequest;
    }

    var makeRequest = function (url, method, data) {
        var defer = Q.defer();

        $.ajax({
            url: url,
            method: method,
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: {
                'X-Parse-Application-Id': 'E1ZmmIAZCAY8o1z7523lUbwgvdTY3RFNTfuhbafi',
                'X-Parse-REST-API-Key': 'Mh9LKEdFxjtZGic11jZL2HSAXewF9sc10eRvLpap'
            },
            success: function (data) {
                defer.resolve(data);
            },
            error: function (error) {
                defer.reject(error);
            }
        });

        return defer.promise;
    };

    var makeGetRequest = function (url, headers) {
        return makeRequest(url, 'GET', null, headers);
    };

    var makePostRequest = function (url, data, headers) {
        return makeRequest(url, 'POST', data, headers);
    };

    var makePutRequest = function (url, data, headers) {
        return makeRequest(url, 'PUT', data, headers);
    };

    var makeDeleteRequest = function (url, headers) {
        return makeRequest(url, 'DELETE', null, headers);
    };

    return {
        get: function () {
            return new AjaxRequester();
        }
    }
}());