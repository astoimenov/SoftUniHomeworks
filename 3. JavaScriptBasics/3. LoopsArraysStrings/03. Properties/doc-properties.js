function displayProperties() {
    var properties = [];
    for (var prop in document) {
        properties.push(prop);
    }
    properties.sort();
    for (var i = 0; i < properties.length; i += 1) {
        document.getElementById('js-console').innerHTML += properties[i] + '<br>';
    }
}
displayProperties();
