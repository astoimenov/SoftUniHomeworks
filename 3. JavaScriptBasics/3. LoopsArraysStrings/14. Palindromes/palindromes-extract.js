function findPalindromes(text) {
    var toLower = text.toLowerCase();
    var i;
    var words = toLower.split(/[\W]+/).filter(Boolean);
    var result = [];

    for (i = 0; i < words.length; i++) {
        if (words[i] == words[i].split('').reverse().join('')) {
            result.push(words[i]);
        }
    }
    jsConsole.writeLine(text);
    jsConsole.writeLine(result.join(', '));
    jsConsole.writeLine();
}
