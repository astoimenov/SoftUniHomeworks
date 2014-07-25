function reverseString(string) {
    var strArray = [];
    var i;
    var reversed = '';
    for (i = 0; i < string.length; i++) {
        strArray.push(string.charAt(i));
    }
    strArray.reverse();
    reversed = strArray.join('');
    jsConsole.writeLine(string);
    jsConsole.writeLine(reversed);
    jsConsole.writeLine();
}
