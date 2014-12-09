(function () {

    $.getJSON('books.json', function (books) {

        var groupedBook = _.chain(books)
            .sortBy(function (book) {
                return book.author + ' ' + book.price;
            }).groupBy('language').value();

        var result;
        var output = '';
        var template;

        for (var key in groupedBook) {
            output += '<div>' + key + ':</div>';
            result = {
                groupedBook: groupedBook[key]
            };

            template = '{{#groupedBook}}<div>{{author}} - <strong>{{book}}</strong> - price: {{price}} - language: {{language}}</div>{{/groupedBook}}';
            output += Mustache.render(template, result) + '<br/>';
        }

        output += '<br/>';
        groupedBook = _.chain(books).groupBy('author').value();

        for (var author in groupedBook) {
            result = {
                author: author,
                averagePrice: (_.chain(groupedBook[author])
                    .reduce(function (sum, book) {
                        return sum + Number(book.price);
                    }, 0).value()) / groupedBook[author].length
            };

            template = '<div>{{author}} - average price: {{averagePrice}}</div>';
            output += Mustache.render(template, result);
        }

        output += '<br/><br/>';

        groupedBook = _.chain(books)
            .filter(function (book) {
                return (book.language === 'English' ||
                    book.language === 'German') &&
                    Number(book.price) < 30;
            }).groupBy('author').value();

        for (author in groupedBook) {
            result = {
                groupedBook: groupedBook[author]
            };

            template = '{{#groupedBook}}<div>{{author}} - <strong>{{book}}</strong> - price: {{price}} - language: {{language}}</div>{{/groupedBook}}';
            output += Mustache.render(template, result) + '<br/>';
        }

        output += '<br/>';
        $('body').html(output);
    });
}());