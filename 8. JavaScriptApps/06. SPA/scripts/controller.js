'use strict';

var app = app || {};

app.controller = (function () {
    function BaseController(data) {
        this._data = data;
    }

    BaseController.prototype.loadBooks = function (selector) {
        this._data.books.getAll()
            .then(
            function (data) {
                $.get('templates/books.mustache', function (template) {
                    var output = Mustache.render(template, data);
                    $(selector).html(output);
                });
            },
            function (error) {
                console.log(error);
            });
    };

    var attachCreateBookHandler = function () {
        var _this = this;
        var selector = '#add-book-wrapper';

        $(selector).on('click', '#create-book', function () {
            var title = $('#title').val();
            var author = $('#author').val();
            var isbn = $('#isbn').val();

            var book = {
                title: title,
                author: author,
                isbn: isbn
            };

            _this._data.books.add(book)
                .then(function (data) {
                    _this._data.books.getById(data.objectId)
                        .then(
                        function (book) {
                            $.get('templates/book.mustache', function (template) {
                                var output = Mustache.render(template, book);
                                $('#wrapper').append(output);
                            });

                            $('#title').val('');
                            $('#author').val('');
                            $('#isbn').val('');
                        },
                        function (error) {
                            console.log(error);
                        });
                });
        });
    };

    var attachEditBookHandler = function (selector) {
        var _this = this;
        var appended = false;

        $(selector).on('click', '.edit-book-btn', function (ev) {
            var parent = $(ev.target).parent();
            var bookId = parent.attr('id');

            _this._data.books.getById(bookId)
                .then(
                function (book) {
                    if (!appended) {
                        $.get('templates/edit-form.mustache', function (template) {
                            var output = Mustache.render(template, book);
                            parent.append(output);
                            appended = true;
                        });
                    }
                },
                function (error) {
                    console.log(error);
                });
        });
    };

    var attachSaveEditHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '#save-edit-btn', function (ev) {
            var parent = $(ev.target).parent().parent();
            var bookId = parent.attr('id');

            var title = $('#edit-title').val();
            var author = $('#edit-author').val();
            var isbn = $('#edit-isbn').val();
            var book = {
                title: title,
                author: author,
                isbn: isbn
            };

            _this._data.books.edit(bookId, book)
                .then(
                function () {
                    _this._data.books.getById(bookId)
                        .then(
                        function (book) {
                            $.get('templates/book.mustache', function (template) {
                                var output = Mustache.render(template, book);
                                parent.html(output);
                            });

                            $('#edit-title').val('');
                            $('#edit-author').val('');
                            $('#edit-isbn').val('');
                        },
                        function (error) {
                            console.log(error.error);
                        }
                    );
                }
            );
        });
    };


    var attachDeleteBookHandler = function (selector) {
        var _this = this;

        $(selector).on('click', '.delete-book-btn', function (ev) {
            var bookId = $(this).parent().attr('id');
            _this._data.books.delete(bookId)
                .then(
                function () {
                    $(ev.target).parent().remove();
                },
                function (error) {
                    console.log(error);
                });
        });
    };

    BaseController.prototype.attachEventHandlers = function () {
        var selector = '#wrapper';
        attachCreateBookHandler.call(this, selector);
        attachDeleteBookHandler.call(this, selector);
        attachEditBookHandler.call(this, selector);
        attachSaveEditHandler.call(this, selector);
    };

    return {
        get: function (data) {
            return new BaseController(data);
        }
    }
}());