function primeNumber() {
    var number = jsConsole.readInteger('#tb-number');
    var isPrime = true;
    for (var i = 2; i <= Math.sqrt(number); i++) {
        if ((number % i == 0) || number < 2) {
            isPrime = false;
        }
    }
    jsConsole.writeLine(isPrime.toString());
}
