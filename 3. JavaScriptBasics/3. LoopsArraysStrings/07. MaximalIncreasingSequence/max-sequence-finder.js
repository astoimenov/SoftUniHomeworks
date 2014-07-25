function findMaxSequence(sequence) {
    var i;
    var current = [sequence[0]];
    var maxSequence = [sequence[0]];
    var currentElement, previousElement, result;

    for (i = 1; i < sequence.length; i += 1) {
        currentElement = sequence[i];
        previousElement = sequence[i - 1];

        if (currentElement > previousElement) {
            current.push(currentElement);
            if (i === sequence.length - 1 && maxSequence.length <= current.length) {
                maxSequence = current;
            }
        } else {

            if (maxSequence.length <= current.length) {
                maxSequence = current;
            }
            current = [currentElement];
        }
    }
    if (maxSequence.length === 1) {
        maxSequence = 'no';
    } else {
        maxSequence = '[' + maxSequence + ']';
    }
    jsConsole.writeLine('[' + sequence + ']');
    jsConsole.writeLine('Max: ' + maxSequence);
    jsConsole.writeLine();
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);
