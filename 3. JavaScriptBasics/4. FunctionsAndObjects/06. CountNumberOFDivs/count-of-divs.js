function countDivs(html) {
    var divTag = '<div';
    var substrings = html.split(divTag);
    var count = substrings.length - 1;
    jsConsole.writeLine(count);
    jsConsole.writeLine();
}
