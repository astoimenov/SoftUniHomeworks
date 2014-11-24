$.fn.capitalize = function () {
    $.each(this, function () {
        var caps = this.value;
        caps = caps.charAt(0).toUpperCase() + caps.slice(1);
        this.value = caps;
    });
    return this;
};

$(document).ready(function () {

        $('#container').append('<table>');
        $('table').append('<thead>');
        $('thead').after('<tbody>');

        $.getJSON('cars-data.json', function (response) {
            var keys = [];
            $.each(response[0], function (key) {
                $('thead').append('<th>' + key + '</th>');
            });

            $.each(response, function () {
                $('tbody').append('<tr id="' + this.manufacturer + '"></tr>');
                var manufacturerId = $('#' + this.manufacturer);
                manufacturerId.append('<td class="manufacturer">' + this.manufacturer + '</td>');
                manufacturerId.append('<td class="model">' + this.model + '</td>');
                manufacturerId.append('<td class="year">' + this.year + '</td>');
                manufacturerId.append('<td class="price">' + this.price + '</td>');
                manufacturerId.append('<td class="class">' + this.class + '</td>');
            });
        });
});