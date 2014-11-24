function printNumbers(number) {
    var counter = 0;
    var numbers = [];
    for (var i = 1; i <= number; i += 1) {
        if (!(i % 4 == 0 || i % 5 == 0)) {
            numbers.push(i);
            counter += 1;
        }
        if (counter == 0) {
            jsConsole.writeLine('no');
        }
    }
    console.log(numbers.join(', '));
}
printNumbers(20);
