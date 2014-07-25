function findMostFreqNum(sequence) {
    jsConsole.writeLine('[' + sequence + ']');
    sequence.sort();
    var current = [sequence[0]];
    var maxSequence = [sequence[0]];
    var currentElement, previousElement, i;

    for (i = 1; i < sequence.length; i += 1) {
        currentElement = sequence[i];
        previousElement = sequence[i - 1];

        if (currentElement === previousElement) {
            current.push(currentElement);
            if (i === sequence.length - 1 && maxSequence.length <= current.length) {
                maxSequence = current;
            }
        } else {

            if (maxSequence.length < current.length) {
                maxSequence = current;
            }
            current = [currentElement];
        }
    }
    jsConsole.writeLine(maxSequence[0] + ' (' + maxSequence.length + ') times');
    jsConsole.writeLine();
}
findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);
