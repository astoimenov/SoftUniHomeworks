function findMaxSequence(sequence) {
    var i;
    var current = [sequence[0]];
    var maxSequence = [sequence[0]];
    var currentElement, previousElement;

    for (i = 1; i < sequence.length; i += 1) {
        currentElement = sequence[i];
        previousElement = sequence[i - 1];

        if (currentElement === previousElement) {
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
    jsConsole.writeLine('[' + sequence + ']');
    jsConsole.writeLine('Max: [' + maxSequence + ']');
    jsConsole.writeLine();
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
