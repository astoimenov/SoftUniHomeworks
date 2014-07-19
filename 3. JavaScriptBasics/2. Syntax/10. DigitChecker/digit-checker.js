function digitChecker(number) {
    if ((Math.floor(number / 100) % 10) == 3) {
        jsConsole.writeLine('true');
    } else {
        jsConsole.writeLine('false');
    }
}
