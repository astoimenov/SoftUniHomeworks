'use strict';

var app = app || {};

app.data = (function () {
    function Data(baseUrl, ajaxRequester) {
        this.books = new Books(baseUrl, ajaxRequester);
    }

    var Books = (function () {
        function Books(baseUrl, ajaxRequester) {
            this._serviceUrl = baseUrl + 'classes/Book';
            this._ajaxRequester = ajaxRequester;
        }

        Books.prototype.getAll = function () {
            return this._ajaxRequester.get(this._serviceUrl);
        };

        Books.prototype.getById = function (objectId) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.get(url);
        };

        Books.prototype.add = function (book) {
            return this._ajaxRequester.post(this._serviceUrl, book);
        };

        Books.prototype.edit = function (objectId, book) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.put(url, book);
        };

        Books.prototype.delete = function (objectId) {
            var url = this._serviceUrl + '/' + objectId;
            return this._ajaxRequester.delete(url);
        };

        return Books;
    }());

    return {
        get: function (baseUrl, ajaxRequester) {
            return new Data(baseUrl, ajaxRequester);
        }
    }
}());