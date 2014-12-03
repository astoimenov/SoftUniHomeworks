var application = application || {};

application.controller = (function () {
    function Main(dataPersister) {
        this.persister = dataPersister;
    }

    Main.prototype.load = function (selector) {
        this.attachEventHandlers();
        this.loadBooks(selector);
    };

    Main.prototype.loadBooks = function (selector) {
        this.persister.books.getAll(
            function (data) {
                $(selector).empty();

                for (var c in data.results) {
                    var book = data.results[c];
                    var bookItem = $('<li>');
                    var bookTitle = $('<span>').text(book.title
                    + ' - ' + book.author + ' (' + book.isbn + ');');
                    $(bookTitle).data('book', book);
                    bookTitle.appendTo(bookItem);
                    bookItem.append($('<button class="remove-book">Remove book</button>'));
                    bookItem.attr('data-id', book.objectId);
                    var editForm = '<div id="edit-student-wrapper' + book.objectId + '">' +
                        '<label for="edit-book-title' + book.objectId + '">Title: </label>' +
                        '<input type="text" id="edit-book-title' + book.objectId + '">' +
                        '<label for="edit-book-author' + book.objectId + '">Author: </label>' +
                        '<input type="text" id="edit-book-author' + book.objectId + '">' +
                        '<label for="edit-book-isbn' + book.objectId + '">ISBN: </label>' +
                        '<input type="text" id="edit-book-isbn' + book.objectId + '">' +
                        '<input type="button" value="Edit book" class="edit-book-btn">' +
                        ' </div>';
                    $(editForm).appendTo(bookItem);
                    bookItem.appendTo($(selector));
                }
            },
            function (error) {
                console.log(error);
                $(selector).html(error)
            });
    };

    Main.prototype.attachEventHandlers = function () {
        var _this = this;
        $('#add-book-btn').on('click', function (ev) {
            var book = {
                title: $('#add-book-title').val(),
                author: $('#add-book-author').val(),
                isbn: $('#add-book-isbn').val()
            };
            _this.persister.books.add(book,
                function (data) {
                    _this.loadBooks('.result');
                },
                function (error) {
                    console.log(error);
                }
            );
            ev.preventDefault();
            return false;
        });

        var result = $('.result');

        result.on('click', '.remove-book', function (ev) {
            var id = $(this).parent().attr('data-id');
            _this.persister.books.remove(id,
                function (id) {
                    _this.loadBooks('.result');
                },
                function (error) {
                    console.log(error);
                }
            );
        });

        result.on('click', '.edit-book-btn', function (ev) {
            var id = $(this).parent().parent().attr('data-id');
            var book = {
                title: $('#edit-book-title' + id).val(),
                author: $('#edit-book-author' + id).val(),
                isbn: $('#edit-book-isbn' + id).val()
            };

            _this.persister.books.edit(id, book,
                function (id) {
                    _this.loadBooks('.result');
                },
                function (error) {
                    console.log(error);
                }
            );
        });
    };

    return {
        get: function (dataPersister) {
            return new Main(dataPersister);
        }
    }
}());