function sortArray(arr) {
    var i, j, temp, min;
    var start = 0;
    var end = arr.length;
    jsConsole.writeLine('[' + arr + ']');
    for (i = start; i < end; ++i) {
        min = i;
        for (j = i; j < end; ++j) {
            if (arr[min] > arr[j]) {
                min = j;
            }
        }
        temp = arr[min];
        arr[min] = arr[i];
        arr[i] = temp;

    }
    jsConsole.writeLine(arr);
    jsConsole.writeLine();
}
sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);
