$(function() {
    var PARSE_APP_ID = "E1ZmmIAZCAY8o1z7523lUbwgvdTY3RFNTfuhbafi";
    var PARSE_REST_API_KEY = "Mh9LKEdFxjtZGic11jZL2HSAXewF9sc10eRvLpap";

    loadCountries();

    function loadCountries() {
        $.ajax({
            method: "GET",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: "https://api.parse.com/1/classes/Country",
            success: countriesLoaded
        });
    }

    function countriesLoaded(data) {
        var body = $('body');
        body.append('<h2>Countries</h2>')
            .append('<input type="text" id="add-country-text" />')
            .append('<button id="add-country">Add a country</a>')
            .append('<ul class="countries"></ul>');
        $('#add-country').click(addCountry);

        for (var q in data.results) {
            var country = data.results[q];
            var countryItem = $("<li>");
            var countryLink = $("<a href='#'>").text(country.name);
            $(countryLink).data("country", country);
            countryLink.appendTo(countryItem);
            $(countryLink).click(countryClicked);
            addControlButtons(countryItem, country);
            countryItem.appendTo($(".countries"));
        }

        $('.edit-country').click(editCountry);
    }

    function addControlButtons(countryItem, country){
        var removeButton = $('<button class="remove-country">Remove</button>');
        removeButton.data('country', country);
        removeButton.click(removeCountry);
        var editButton = $('<button class="edit-country">Edit</button>');
        editButton.data('country', country);
        editButton.click(editCountry);
        countryItem.append(' ')
            .append(editButton)
            .append(' ')
            .append(removeButton);
    }

    function addCountry(){
        var countryName = $('#add-country-text').val();
        $.ajax({
            method: "PUT",
            url: "https://api.parse.com/1/classes/Country/",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            data: JSON.stringify(
                {"name": countryName}
            ),
            contentType: "application/json",
            error: errorLoadData
        });
    }

    function editCountry(){
        var country = $(this).data('country');
        var oldCountryName = country.name;
        var newCountryName = prompt('Rename country:', oldCountryName) || oldCountryName;
        $.ajax({
            method: "PUT",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            data: JSON.stringify(
                {"name": newCountryName}
            ),
            contentType: "application/json",
            url: "https://api.parse.com/1/classes/Country/" + country.objectId,
            error: errorLoadData
        });
    }

    function removeCountry(){
        var country = $(this).data('country');
        $.ajax({
            method: "DELETE",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: "https://api.parse.com/1/classes/Country/" + country.objectId,
            success: loadCountries
        });
    }

    function countryClicked() {
        var country = $(this).data("country");
        var towns = $("#towns");
        towns.hide();
        towns.find("h2").text(country.name);
        var countryId = country.objectId;
        $.ajax({
            method: "GET",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: 'https://api.parse.com/1/classes/Town?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + countryId + '"}}',
            success: townsLoaded
        });
    }

    function townsLoaded(data) {
        var towns = $("#towns");
        towns.find("ul").html('');
        for (var a in data.results) {
            var town = data.results[a];
            var townItem = $("<li>");
            townItem.text(town.name);
            townItem.appendTo(towns.find("ul"));
        }

        towns.show();
    }

    function errorLoadData(){
        $(function () {
            modal({
                type: 'alert',
                title: 'Error!',
                text: 'Problem with connection with database.'
            });
        })
    }
});