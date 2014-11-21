$.fn.capitalize = function () {
    $.each(this, function () {
        var caps = this.value;
        caps = caps.charAt(0).toUpperCase() + caps.slice(1);
        this.value = caps;
    });
    return this;
};

$(document).ready(function () {
    $('#generate').click(function () {

        $('#container').append('<table><thead></thead><tbody></tbody></table>');

        $.getJSON('cars-data.json', function (response) {

            $.each(response[0], function (key) {
                $('thead').append('<th>' + key + '</th>');
            });

            $.each(response, function () {
                $('tbody').append('<tr id="' + this.manufacturer + '"></tr>');
                $('#' + this.manufacturer)
                    .append('<td class="manufacturer">' + this.manufacturer + '</td>');
                $('#' + this.manufacturer)
                    .append('<td class="model">' + this.model + '</td>');
                $('#' + this.manufacturer)
                    .append('<td class="year">' + this.year + '</td>');
                $('#' + this.manufacturer)
                    .append('<td class="price">' + this.price + '</td>');
                $('#' + this.manufacturer)
                    .append('<td class="class">' + this.class + '</td>');
            });
        });
    });
});