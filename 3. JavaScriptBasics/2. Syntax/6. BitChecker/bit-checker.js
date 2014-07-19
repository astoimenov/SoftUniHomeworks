function bitChecker (num) {
	var bin = Number(num).toString(2);
	var reversedBin = bin.toString().split('').reverse().join('');
	if (reversedBin.charAt(3) == 1) {
		jsConsole.writeLine('true');
	} else {
		jsConsole.writeLine('false');
	}
}
