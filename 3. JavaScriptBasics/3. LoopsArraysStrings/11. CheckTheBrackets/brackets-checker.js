function checkBrackets(expression) {
    var leftBr = '(';
    var rightBr = ')';
    var leftBrCount = 0;
    var rightBrCount = 0;
    var i;
    for (i = 0; i < expression.length; i++) {
        if (expression.charAt(i) == leftBr) {
            leftBrCount++;
        } else if (expression.charAt(i) == rightBr) {
            rightBrCount++;
        }
    }
    jsConsole.writeLine(expression);
    if (leftBrCount == rightBrCount) {
        jsConsole.writeLine('correct');
    } else {
        jsConsole.writeLine('incorrect');
    }
    jsConsole.writeLine();
}
