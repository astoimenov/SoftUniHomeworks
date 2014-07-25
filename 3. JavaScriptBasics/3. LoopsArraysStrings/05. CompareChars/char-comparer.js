function compareChars(firstArray, secondArray) {
	var firstSum = 0;
	var secondSum = 0;

	for (var i = 0; i < firstArray.length; i += 1) {
		firstSum += firstArray[i].charCodeAt(0);
	}
	for (var i = 0; i < secondArray.length; i += 1) {
		secondSum += secondArray[i].charCodeAt(0);
	}
	jsConsole.writeLine('[' + firstArray + ']');
	jsConsole.writeLine('[' + secondArray+ ']');
	if (firstSum == secondSum) {
		jsConsole.writeLine('Equal');
	} else {
		jsConsole.writeLine('Not equal')
	}
	jsConsole.writeLine();
}
compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']);
compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']);
compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']);
