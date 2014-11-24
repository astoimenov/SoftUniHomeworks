function reverseWordsInString(str) {
    var result = '';
    var i;
    var words = str.split(' ');
    for (i = 0; i < words.length; i += 1) {
        result += words[i].split('').reverse().join('') + ' ';
    }

    jsConsole.writeLine(str);
    jsConsole.writeLine(result);
    jsConsole.writeLine();
}
