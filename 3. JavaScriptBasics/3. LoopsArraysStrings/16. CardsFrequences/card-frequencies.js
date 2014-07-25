function findCardFrequency(input) {
    var cards = input.split(/\W+/);
    var cardsMap = {};

    for (var i = 0; i < cards.length - 1; i++) {
        if (cards[i].match(/\w/)) {
            cardsMap[cards[i]] = (cardsMap[cards[i]] || 0) + 1;
        }
    }

    for (var key in cardsMap) {
        jsConsole.writeLine(key + ' -> ' + (cardsMap[key] / (cards.length - 1) * 100).toFixed(2) + '%');
    }
    jsConsole.writeLine();

}
