function divisionBy3(n) {
    var sum = 0;
    while (n > 0) {
        sum += n % 10;
        n = Math.floor(n / 10);
    }
    if (sum % 3) {
        jsConsole.writeLine('the number is not divided by 3 without remainder');
    } else {
        jsConsole.writeLine('the number is divided by 3 without remainder');
    }
}
