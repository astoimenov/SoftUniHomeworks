function findLargestBySumOfDigits(nums) {
    var max = 0;
    var currentNumber = 0;
    var i, j, result;

    jsConsole.writeLine(nums.join(', '));

    for (i = 0; i < nums.length; i += 1) {
        if (parseInt(nums[i]) !== nums[i] || arguments.length < 1) {
            result = 'undefined';
        }
        var currentNumber = Math.abs(nums[i]).toString();
        var sum = 0;
        for (j = 0; j < currentNumber.length; j += 1) {
            sum += Number(currentNumber[j]);
        }
        if (sum >= max) {
            result = nums[i];
            max = sum;
        }
    }
    jsConsole.writeLine(result);
    jsConsole.writeLine();
}
findLargestBySumOfDigits([5, 10, 15, 111]);
findLargestBySumOfDigits(['hello'])
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits([5, 3.3]);
