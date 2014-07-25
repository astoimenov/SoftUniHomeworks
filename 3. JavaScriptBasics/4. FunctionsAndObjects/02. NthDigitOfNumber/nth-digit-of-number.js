function findNthDigit(arr) {
    jsConsole.writeLine('[' + arr.join(', ') + ']');
    var num = arr[1].toString().replace('.', '');
    var n = arr[0];
    var nth = num.charAt(num.length - n);
    if (nth !== '') {
        jsConsole.writeLine(nth);
    } else {
        jsConsole.writeLine('The number doesn\'t have ' + n + ' digits');
    }
    jsConsole.writeLine();
}
findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);
